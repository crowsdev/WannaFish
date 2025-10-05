using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COOPSAPI;
using Telerik.Charting;
using Telerik.WinControls.UI;
using WannaFish.CAMS;
using WannaFish.OpenMeteoAPI;
using TimeInterval = Telerik.WinControls.UI.TimeInterval;

namespace WannaFish
{
    public partial class RadFormMain : Telerik.WinControls.UI.RadForm
    {
        public RadFormMain()
        {
            InitializeComponent();

            this.vlcControl1.Play(new Uri(Streams.MyrtleGrove));

            InitGridView();

            HandleTideChart(GetLatestTidalPredictionData());

            HandleWeatherTable(GetWeather7Day());
        }

        #region CAMS

        /// <summary>
        /// When the Vlc control needs to find the location of the libvlc.dll.
        /// You could have set the VlcLibDirectory in the designer, but for this sample, we are in AnyCPU mode, and we don't know the process bitness.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }

        #endregion

        private void radButtonElement_myrtle_Click(object sender, EventArgs e)
        {
            this.vlcControl1.Play(new Uri(Streams.MyrtleGrove));
        }

        private void radButtonElement_carolinabeach_Click(object sender, EventArgs e)
        {
            this.vlcControl1.Play(new Uri(Streams.CarolinaBeachCenter));
        }

        private void radButtonElement_wrightsville_Click(object sender, EventArgs e)
        {
            this.vlcControl1.Play(new Uri(Streams.WrightsvilleBeachOceanicRestaurant));
        }

        #region Remote Data

        private TidalPrediction GetLatestTidalPredictionData()
        {
            TidalPrediction result = null;
            using (WebClient wc = new WebClient())
            {
                string rsp = wc.DownloadString(COOPSAPI.Urls.LatestTidePredictionUrl_Json0);
                result = TidalPrediction.FromJson(rsp);
            }

            return result;
        }

        private WeatherData001 GetWeather7Day()
        {
            WeatherData001 result = null;
            using (WebClient wc = new WebClient())
            {
                string rsp = wc.DownloadString(RequestUrls.WeatherData001_7Day);
                result = WeatherData001.FromJson(rsp);
            }

            return result;
        }

        #endregion

        #region Tide Chart

        private void HandleTideChart(TidalPrediction _tidalPrediction)
        {
            LineSeries series = new LineSeries();

            foreach (Prediction prediction in _tidalPrediction.Predictions)
            {
                double val = 0;
                if (!double.TryParse(prediction.V, out val))
                {
                    MessageBox.Show($"ERROR parsing {prediction.V}.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DateTime dt = DateTime.Now;
                string frmt = "yyyy-MM-dd HH:mm";
                if (!DateTime.TryParseExact(prediction.T, frmt, null, DateTimeStyles.AssumeLocal, out dt))
                {
                    MessageBox.Show($"Error parsing {prediction.T} as DateTime.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                series.DataPoints.Add(new CategoricalDataPoint(val, dt));
            }


            // series.DataPoints.Add(new CategoricalDataPoint(6, DateTime.Now));
            // series.DataPoints.Add(new CategoricalDataPoint(4, DateTime.Now.AddDays(1)));
            // series.DataPoints.Add(new CategoricalDataPoint(7, DateTime.Now.AddDays(2)));
            // series.DataPoints.Add(new CategoricalDataPoint(5, DateTime.Now.AddDays(3)));
            // DateTimeCategoricalAxis categoricalAxis = new DateTimeCategoricalAxis();
            DateTimeContinuousAxis categoricalAxis = new DateTimeContinuousAxis();
            // categoricalAxis.DateTimeComponent = DateTimeComponent.TimeOfDay;
            categoricalAxis.PlotMode = AxisPlotMode.BetweenTicks;
            // categoricalAxis.LabelFormat = "{0:m}";
            categoricalAxis.LabelFormat = "{0:HH:mm}";
            categoricalAxis.MajorStepUnit = Telerik.Charting.TimeInterval.Hour;
            categoricalAxis.MajorStep = 1;
            categoricalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
            //First assign the axis to the VerticalAxis property and then add the series to the chart
            series.HorizontalAxis = categoricalAxis;

            LinearAxis la = new LinearAxis();
            la.AxisType = AxisType.Second;
            la.MajorStep = 0.5f;
            la.Title = "Height(ft)";

            series.VerticalAxis = la;

            radChartView1.Area.View.Palette = KnownPalette.Rainbow;
            this.radChartView1.Area.Grid.BackColor = Color.DimGray;
            this.radChartView1.Area.Grid.AlternatingBackColor = Color.Gray;
            radChartView1.Series.Add(series);
            radChartView1.ShowGrid = true;
        }

        #endregion

        #region Weather

        private void InitGridView()
        {
            radGridView1.ReadOnly = true;
            radGridView1.AutoScroll = true;
            radGridView1.AllowAddNewRow = false; 
            radGridView1.AllowDeleteRow = false; 
            radGridView1.AllowDragToGroup = false; 
            radGridView1.AllowEditRow = false; 
            radGridView1.AllowSearchRow = false; 
            radGridView1.EnableFiltering = false; 
            radGridView1.EnableGrouping = false; 
            radGridView1.EnableSorting = false;

            GridViewDateTimeColumn dtCol = new GridViewDateTimeColumn("DateTime");
            radGridView1.Columns.Add(dtCol);
            GridViewTextBoxColumn wsCol = new GridViewTextBoxColumn("WindSpeed");
            radGridView1.Columns.Add(wsCol);
            GridViewTextBoxColumn wdCol = new GridViewTextBoxColumn("WindDirection");
            radGridView1.Columns.Add(wdCol);
            GridViewTextBoxColumn tmCol = new GridViewTextBoxColumn("TemperatureF");
            radGridView1.Columns.Add(tmCol);
            GridViewTextBoxColumn rcCol = new GridViewTextBoxColumn("RainChance");
            radGridView1.Columns.Add(rcCol);

            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void HandleWeatherTable(WeatherData001 _wData)
        {
            for (int i = 0; i < _wData.Hourly.Time.Count; i++)
            {
                DateTime dt = default;
                if (!DateTime.TryParse(_wData.Hourly.Time[i], out dt))
                {
                    MessageBox.Show($"Failed to parse DateTime from {_wData.Hourly.Time[i]}", "AH FUCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                string ws = _wData.Hourly.WindSpeed10M[i].ToString() + " " + _wData.HourlyUnits.WindSpeed10M;
                string wd = DegreesToCardinalDetailed(_wData.Hourly.WindDirection10M[i]);
                string tm = _wData.Hourly.Temperature2M[i].ToString() + " " + _wData.HourlyUnits.Temperature2M.Replace("Â", "");
                string rc = _wData.Hourly.PrecipitationProbability[i].ToString() + " " + _wData.HourlyUnits.PrecipitationProbability;

                radGridView1.Rows.Add(new object[] { dt, ws, wd, tm, rc });
            }
        }

        /// <summary>
        /// Converts degrees to a 16-point cardinal direction string.
        /// </summary>
        /// <param name="degrees">The degree value (0-360).</param>
        /// <returns>The cardinal direction string (e.g., "N", "NNE", "NE").</returns>
        public static string DegreesToCardinalDetailed(long degrees)
        {
            // Normalize degrees to be within 0 and 360
            degrees = (degrees % 360 + 360) % 360;

            string[] cardinals = {
                "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE",
                "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N"
            };

            // Each cardinal direction covers 22.5 degrees (360 / 16)
            // We add 11.25 (half of 22.5) to shift the ranges correctly for rounding.
            // Then divide by 22.5 to get the index.
            // The last "N" in the array handles the wrap-around for degrees close to 360.
            int index = (int)Math.Round((degrees + 11.25) / 22.5);

            // Ensure index stays within the bounds of the array
            if (index >= cardinals.Length)
            {
                index = 0; // Wrap around to N for values like 359.9
            }

            return cardinals[index];
        }

        #endregion
    }
}
