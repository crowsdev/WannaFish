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
using TimeInterval = Telerik.Charting.TimeInterval;

namespace WannaFish
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            // this.vlcControl1.Play(new Uri(@"https://5b17d0ba29814.streamlock.net:9443/live/cb.stream/playlist.m3u8"));
            // this.vlcControl2.Play(new Uri(@"https://5a5f765a4fcc2.streamlock.net:1936/live/cb2.stream/playlist.m3u8"));

            this.vlcControl1.Play(new Uri(Streams.KureBeachFishingPier));
            this.vlcControl2.Play(new Uri(Streams.CarolinaBeachCenter));

            HandleTideChart(GetLatestTidalPredictionData());

            HandleWeatherTable(GetWeather7Day());
        }

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

        #region RadChart

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
            categoricalAxis.MajorStepUnit = TimeInterval.Hour;
            categoricalAxis.MajorStep = 1;
            //First assign the axis to the VerticalAxis property and then add the series to the chart
            series.HorizontalAxis = categoricalAxis;
            radChartView1.Series.Add(series);
        }

        #endregion

        #region Weather

        private void HandleWeatherTable(WeatherData001 _wData)
        {
            // Need to use RadGridView instead of shitty table-layout.





            List<Label> cells = new List<Label>
            {
                this.label_weatherdata_1,
                this.label_weatherdata_2,
                this.label_weatherdata_3,
                this.label_weatherdata_4,
                this.label_weatherdata_5,
                this.label_weatherdata_6,
                this.label_weatherdata_7
            };

            for (int i = 0; i < _wData.Hourly.Time.Count; i++)
            {
                string t = _wData.Hourly.Time[i];
                double f = _wData.Hourly.Temperature2M[i];
                double ws = _wData.Hourly.WindSpeed10M[i];
                long wd = _wData.Hourly.WindDirection10M[i];
                long p = _wData.Hourly.PrecipitationProbability[i];

                string cellTxt = $"{t}\n" +
                                 $"{f} F\n" +
                                 $"{ws} mph\n" +
                                 $"{wd} deg\n" +
                                 $"{(p / 100)}%";
                cells[i].Text = cellTxt;
            }
        }

        #endregion
    }
}
