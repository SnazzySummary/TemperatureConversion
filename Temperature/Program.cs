// See https://aka.ms/new-console-template for more information
using Temperature;

Conversion c = new Conversion();

double t;
double result;

// Celsius_to_Fahrenheit
t = 0d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, t);
Console.WriteLine($"{t} celcius is {result} fahrenheit");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, t);
Console.WriteLine($"{t} celcius is {result} fahrenheit");

