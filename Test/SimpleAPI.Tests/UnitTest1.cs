using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController obj;
        [Fact]
        public void GetReturnValue()
        {
              obj=new WeatherForecastController();
              var objget=obj.Get();
              Assert.Equal("Priyanka gupta",objget.Value);
        }
    }
}
    