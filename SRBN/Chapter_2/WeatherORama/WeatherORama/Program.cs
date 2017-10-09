using System;
using WeatherORama.Display;
using WeatherORama.WeatherData;

namespace WeatherORama
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherObject weatherObject = new WeatherObject();

            new CurrentConditionsDisplay(weatherObject);
            new StatisticsDisplay(weatherObject);
            new ForecastDisplay(weatherObject);
            new HeatIndexDisplay(weatherObject);

            weatherObject.SetMeasurements(80f, 0.65f, 30.4f);
            weatherObject.SetMeasurements(82f, 0.70f, 29.2f);
            weatherObject.SetMeasurements(78f, 0.90f, 29.2f);

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
