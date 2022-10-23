using Vejrudsigten.Services;

namespace WeatherForecastTest
{
    public class WeatherHeaderTest
    {

        [InlineData(-10,-10,"Sne","Klart vejr", "Ekstremt vejr forude med en temperatur på -10 grader og nu med vejrtypen sne")]
        [InlineData(30, 40, "Klart vejr", "Klart vejr", "Ekstremt vejr forude med en temperatur på 30 grader og vi fortsætter med vejrtypen klart vejr")]
        [InlineData(29, 25, "Andet", "Sne", "Vi fortsætter med en velkendt temperatur på 29 grader og nu med vejrtypen andet")]
        [InlineData(-9, -13, "Skyet", "Skyet", "Vi fortsætter med en velkendt temperatur på -9 grader og vi fortsætter med vejrtypen skyet")]
        [InlineData(20, 25, "Skyet", "Sne", "Temperaturen i dag kræver gentænkning af garderobevalg med en temperatur på 20 grader og nu med vejrtypen skyet")]
        [InlineData(25, 20, "Klart vejr", "Klart vejr", "Temperaturen i dag kræver gentænkning af garderobevalg med en temperatur på 25 grader og vi fortsætter med vejrtypen klart vejr")]
        [InlineData(20, 29, "Andet", "Andet", "Temperaturen i dag kræver gentænkning af garderobevalg med en temperatur på 20 grader og vi fortsætter med vejrtypen andet")]
        [InlineData(29, 20, "Sne", "Andet", "Temperaturen i dag kræver gentænkning af garderobevalg med en temperatur på 29 grader og nu med vejrtypen sne")]
        [InlineData(29, 39, "Klart vejr", "Klart vejr", "Temperaturændringen bør skabe bekymring med en temperatur i dag på 29 grader og vi fortsætter med vejrtypen klart vejr")]
        [InlineData(-9, -19, "Sne", "Klart vejr", "Temperaturændringen bør skabe bekymring med en temperatur i dag på -9 grader og nu med vejrtypen sne")]
        [Theory]
        public void test_valid_input_produces_valid_string(double tempToday, double tempYester, string conToday, string conYester, string expectedResult)
        {
            // Arrange
            WeatherHeader sut = new WeatherHeader();

            // Act
            string weatherTitle = sut.GenerateWeatherInformation(conToday, tempToday, conYester, tempYester);

            // Assert
            Assert.Equal(expectedResult, weatherTitle);
        }
    }
}