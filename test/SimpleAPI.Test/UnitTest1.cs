using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
  WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetWeather()
    {
        var response = controller.Get();
        foreach(var weather in response){
          Assert.Equal("Bracing", weather.Summary);
        } 
        Assert.NotNull(response);
    }
}