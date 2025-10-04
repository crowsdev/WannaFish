using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WannaFish.OpenMeteoAPI
{
    public class RequestUrls
    {
        public static string WeatherData001_7Day = @"https://api.open-meteo.com/v1/forecast?latitude=34.2356&longitude=-77.946&hourly=temperature_2m,wind_speed_10m,precipitation_probability,wind_direction_10m&timezone=auto&wind_speed_unit=mph&temperature_unit=fahrenheit&precipitation_unit=inch";
        public static string WeatherData002_Current = @"https://api.open-meteo.com/v1/forecast?latitude=34.2356&longitude=-77.946&current=temperature_2m,precipitation,wind_speed_10m,wind_direction_10m&timezone=auto&forecast_days=1&wind_speed_unit=mph&temperature_unit=fahrenheit&precipitation_unit=inch";

    }
}
