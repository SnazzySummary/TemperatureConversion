using Temperature;
using Xunit;

namespace TemperatureTests;

public class UnitTest
{
    [Fact]
    public void Given0CelciusOutput32Fahrenheit()
    {
        Conversion conversion = new Conversion();
        double expected = 32;
        double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, 0);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given100CelciusOutput212Fahrenheit()
    {
        Conversion conversion = new Conversion();
        double expected = 212;
        double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, 100);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given0KelvinOutputNegative459Point4Fahrenheit()
    {
        Conversion conversion = new Conversion();
        double expected = -459.4;
        double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, 0);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given100KelvinOutputNegative279Point4Fahrenheit()
    {
        Conversion conversion = new Conversion();
        double expected = -279.4;
        double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, 100);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given32FahrenheitOutput0Celsius()
    {
        Conversion conversion = new Conversion();
        double expected = 0;
        double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, 32);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given100FahrenheitOutput37Point78Celsius()
    {
        Conversion conversion = new Conversion();
        double expected = 37.78;
        double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, 100);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given0CelsiusOutput273Kelvin()
    {
        Conversion conversion = new Conversion();
        double expected = 273;
        double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, 0);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given0KelvinOutputNegative273Celsius()
    {
        Conversion conversion = new Conversion();
        double expected = -273;
        double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, 0);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given100KelvinOutputNegative173Celsius()
    {
        Conversion conversion = new Conversion();
        double expected = -173;
        double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, 100);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given0FahrenheitOutput255Point22Celsius()
    {
        Conversion conversion = new Conversion();
        double expected = 255.22;
        double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, 0);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given100FahrenheitOutput310Point78Celsius()
    {
        Conversion conversion = new Conversion();
        double expected = 310.78;
        double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, 100);
        Assert.Equal(expected, actual);
    }
}