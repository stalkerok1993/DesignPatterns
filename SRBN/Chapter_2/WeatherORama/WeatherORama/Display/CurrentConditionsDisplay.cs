using System;
using WeatherORama.WeatherData;

namespace WeatherORama.Display
{
    class CurrentConditionsDisplay : IWeatherDisplay, IObserver
    {
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(IObservable subject)
        {
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature ,4:N1} F degrees and {humidity ,3:P1} humidity.");
        }

        public void Update(IObservable subject)
        {
            WeatherObject weatherData = subject as WeatherObject;
            if (subject != null)
            {
                temperature = weatherData.Temperature;
                humidity = weatherData.RelativeHumidity;

                Display();
            }
        }
    }
}
