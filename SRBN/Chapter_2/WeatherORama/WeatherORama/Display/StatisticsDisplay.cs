using System;
using WeatherORama.WeatherData;

namespace WeatherORama.Display
{
    class StatisticsDisplay : IWeatherDisplay, IObserver
    {
        private float minTemperature = float.MaxValue;
        private float maxTemperature = float.MinValue;

        private float aveTemperature = 0.0f;
        private int aveCount = 0;

        public StatisticsDisplay(IObservable subject)
        {
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Ave/Max/Min temperature = {aveTemperature :N1}/{maxTemperature :N1}/{minTemperature :N1}.");
        }

        public void Update(IObservable subject)
        {
            WeatherObject weatherObject = subject as WeatherObject;
            if (weatherObject != null)
            {
                float temp = weatherObject.Temperature;
                minTemperature = Math.Min(minTemperature, temp);
                maxTemperature = Math.Max(maxTemperature, temp);

                aveCount++;
                aveTemperature = ((aveCount - 1) * aveTemperature + temp) / aveCount;

                Display();
            }
        }
    }
}
