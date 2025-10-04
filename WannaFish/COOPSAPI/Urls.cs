namespace WannaFish.COOPSAPI
{
    public class Urls
    {
        public static string LatestTidePredictionUrl_Xml = @"https://api.tidesandcurrents.noaa.gov/api/prod/datagetter?date=latest&station=8658120&product=predictions&datum=STND&time_zone=lst_ldt&units=english&format=xml";
        public static string LatestTidePredictionUrl_Json = @"https://api.tidesandcurrents.noaa.gov/api/prod/datagetter?date=latest&station=8658120&product=predictions&datum=STND&time_zone=lst_ldt&units=english&format=json";
        public static string LatestTidePredictionUrl_Json0 = @"https://api.tidesandcurrents.noaa.gov/api/prod/datagetter?date=today&station=8658120&product=predictions&datum=STND&time_zone=lst_ldt&units=english&format=json";
        public static string LatestTidePredictionUrl_Json00 = @"https://api.tidesandcurrents.noaa.gov/api/prod/datagetter?date=today&station=8658120&product=predictions&datum=STND&time_zone=lst_ldt&interval=hilo&units=english&format=json";

    }
}
