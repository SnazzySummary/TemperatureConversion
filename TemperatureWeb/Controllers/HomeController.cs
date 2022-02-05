using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TemperatureWeb.Models;
using Temperature;

namespace TemperatureWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(int inputTemp, string from, string to) {
        try {
            Conversion converter = new Conversion();
            string selection = $"{from}_to_{to}";
            Conversion.ConversionMode mode;
            if (selection.Equals(Conversion.ConversionMode.Celsius_to_Fahrenheit.ToString())) {
                mode = Conversion.ConversionMode.Celsius_to_Fahrenheit;
            } else if (selection.Equals(Conversion.ConversionMode.Kelvin_to_Fahrenheit.ToString())) {
                mode = Conversion.ConversionMode.Kelvin_to_Fahrenheit;
            } else if (selection.Equals(Conversion.ConversionMode.Fahrenheit_to_Celsius.ToString())) {
                mode = Conversion.ConversionMode.Fahrenheit_to_Celsius;
            } else if (selection.Equals(Conversion.ConversionMode.Celsius_to_Kelvin.ToString())) {
                mode = Conversion.ConversionMode.Celsius_to_Kelvin;
            } else if (selection.Equals(Conversion.ConversionMode.Kelvin_to_Celsius.ToString())) {
                mode = Conversion.ConversionMode.Kelvin_to_Celsius;
            } else if (selection.Equals(Conversion.ConversionMode.Fahrenheit_to_Kelvin.ToString())) {
                mode = Conversion.ConversionMode.Fahrenheit_to_Kelvin;
            } else {
                ViewBag.outputTemp = inputTemp;
                ViewBag.inputTemp = inputTemp;
                return View("Index");
            }
            
            double result = converter.Convert(mode, inputTemp);
            ViewBag.outputTemp = result;
            ViewBag.inputTemp = inputTemp;
            return View("Index");
        } catch {
            return View();
        }
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
