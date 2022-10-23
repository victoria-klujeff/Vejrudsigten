using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vejrudsigten.Services
{
    public static class WeatherForecast
    {
        public static IWeatherService service { get; set; }
       /* public static string GenerateWeatherInformation(string todayCondition, double todayTemp, string yesterdayCondition, double yesterdayTemp)
        {
            string tempInfo = "";
            string typeInfo = "";
            double tempDifference = Math.Abs(todayTemp - yesterdayTemp);
            if (todayTemp <= -10 || todayTemp >= 30)
                tempInfo = $"Ekstremt vejr forude {todayTemp}";
            else
                if (tempDifference >= 10)
                    tempInfo = $"Temperaturændringen bør skabe bekymring med en temperatur i dag på {todayTemp}";
                else if (tempDifference >= 5)
                    tempInfo = $"Temperaturen i dag kræver gentænkning af garderobevalg med en temperatur på {todayTemp}";
                else if (tempDifference < 5)
                    tempInfo = $"Vi fortsætter med en velkendt temperatur på {todayTemp}";
            if (todayCondition != yesterdayCondition)
                typeInfo = $" og vi fortsætter med vejrtypen {todayCondition.ToLower()}";
            else
                typeInfo = $" og nu med vejrtypen {todayCondition.ToLower()}";
            return tempInfo + typeInfo;
        }*/

        public static async Task<string> GetForecastAsync(string key)
        {
            var myWeatherHeader = new WeatherHeader();
            var todayInfo = await service.GetTodaysWeather(key, "Kolding");
            var yesterdayInfo = await service.GetYesterdaysWeather(key, "Kolding");
            string todayCondition = todayInfo.Conditions;
            double todayTemp = todayInfo.Temperature;
            string yesterdayCondition = yesterdayInfo.Conditions;
            double yesterdayTemp = yesterdayInfo.Temperature;
            string result = myWeatherHeader.GenerateWeatherInformation(todayCondition, todayTemp, yesterdayCondition, yesterdayTemp);
            return result;
        }
    }
}
