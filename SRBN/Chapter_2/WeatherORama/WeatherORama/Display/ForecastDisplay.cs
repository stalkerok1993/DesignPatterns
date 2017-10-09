using System;
using System.Collections.Generic;
using WeatherORama.WeatherData;

namespace WeatherORama.Display
{
    class ForecastDisplay : IWeatherDisplay, IObserver
    {
        private readonly Random rand = new Random(DateTime.Now.Millisecond);
        private readonly List<string> forecasts = new List<string>()
        {
            "More of the same.",
            "Improving veather on the way!",
            "Watch out for cooler, rainy weather."
        };
        private int currentForecastId;

        public ForecastDisplay(IObservable subject)
        {
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast: " + forecasts[currentForecastId]);
        }

        public void Update(IObservable subject)
        {
            // seem to work like every daily forecast this days.
            currentForecastId = rand.Next(0, forecasts.Count);

            Display();
        }
    }
}
