using    System;

namespace Vejrudsigten.Services
{
    public class WeatherHeader
    {
        public string GenerateWeatherInformation(string todayCondition, double todayTemp, string yesterdayCondition, double yesterdayTemp)
        {
            string tempInfo = "";
            string typeInfo = "";
            double tempDifference = Math.Abs(todayTemp - yesterdayTemp);
            if (todayTemp <= -10 || todayTemp >= 30)
                tempInfo = $"Ekstremt vejr forude med en temperatur på {todayTemp} grader";
            else
                if (tempDifference >= 10)
                tempInfo = $"Temperaturændringen bør skabe bekymring med en temperatur i dag på {todayTemp} grader";
            else if (tempDifference >= 5)
                tempInfo = $"Temperaturen i dag kræver gentænkning af garderobevalg med en temperatur på {todayTemp} grader";
            else if (tempDifference < 5)
                tempInfo = $"Vi fortsætter med en velkendt temperatur på {todayTemp} grader";
            if (todayCondition != yesterdayCondition)
                typeInfo = $" og nu med vejrtypen {todayCondition.ToLower()}";
            else
                typeInfo = $" og vi fortsætter med vejrtypen {todayCondition.ToLower()}";
            return tempInfo + typeInfo;
        }
    }
}
