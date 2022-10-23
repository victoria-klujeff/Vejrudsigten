using Vejrudsigten.Services;

namespace WeatherForecastTest
{
    public class WeatherHeaderTest
    {

        [InlineData(-10,-10,"Sne","Klart vejr", "Ekstremt vejr forude med en temperatur p� -10 grader og nu med vejrtypen sne")]
        [InlineData(30, 40, "Klart vejr", "Klart vejr", "Ekstremt vejr forude med en temperatur p� 30 grader og vi forts�tter med vejrtypen klart vejr")]
        [InlineData(29, 25, "Andet", "Sne", "Vi forts�tter med en velkendt temperatur p� 29 grader og nu med vejrtypen andet")]
        [InlineData(-9, -13, "Skyet", "Skyet", "Vi forts�tter med en velkendt temperatur p� -9 grader og vi forts�tter med vejrtypen skyet")]
        [InlineData(20, 25, "Skyet", "Sne", "Temperaturen i dag kr�ver gent�nkning af garderobevalg med en temperatur p� 20 grader og nu med vejrtypen skyet")]
        [InlineData(25, 20, "Klart vejr", "Klart vejr", "Temperaturen i dag kr�ver gent�nkning af garderobevalg med en temperatur p� 25 grader og vi forts�tter med vejrtypen klart vejr")]
        [InlineData(20, 29, "Andet", "Andet", "Temperaturen i dag kr�ver gent�nkning af garderobevalg med en temperatur p� 20 grader og vi forts�tter med vejrtypen andet")]
        [InlineData(29, 20, "Sne", "Andet", "Temperaturen i dag kr�ver gent�nkning af garderobevalg med en temperatur p� 29 grader og nu med vejrtypen sne")]
        [InlineData(29, 39, "Klart vejr", "Klart vejr", "Temperatur�ndringen b�r skabe bekymring med en temperatur i dag p� 29 grader og vi forts�tter med vejrtypen klart vejr")]
        [InlineData(-9, -19, "Sne", "Klart vejr", "Temperatur�ndringen b�r skabe bekymring med en temperatur i dag p� -9 grader og nu med vejrtypen sne")]
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