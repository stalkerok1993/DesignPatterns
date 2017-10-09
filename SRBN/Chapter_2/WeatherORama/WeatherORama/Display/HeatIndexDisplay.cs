using System;
using WeatherORama.WeatherData;

namespace WeatherORama.Display
{
    class HeatIndexDisplay : IWeatherDisplay, IObserver
    {
        private float heatIndex;

        public HeatIndexDisplay(IObservable subject)
        {
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is {heatIndex ,4:N1} F.");
        }

        public void Update(IObservable subject)
        {
            WeatherObject weatherObject = subject as WeatherObject;
            if (weatherObject != null)
            {
                float T = weatherObject.Temperature;
                float RH = weatherObject.RelativeHumidity;

                heatIndex = 16.923f +
                    1.85212f * T / 10f +
                    537.941f * RH -
                    10.0254f * T * RH +
                    9.41695f * T * T / 1000f +
                    72.8898f * RH * RH +
                    3.45372f * T * T * RH / 100f -
                    8.14971f * T * RH * RH +
                    1.02102f * T * T * RH * RH / 10f -
                    3.86460f * T * T * T / 100000f +
                    29.1583f * RH * RH * RH +
                    1.42721f * T * T * T * RH / 10000f +
                    1.97483f * T * RH * RH * RH / 10f -
                    2.18429f * T * T * T * RH * RH / 10000f +
                    8.43296f * T * T * RH * RH * RH / 10000f - 
                    4.81975f * T * T * T * RH * RH * RH / 100000f;

                Display();
            }
        }
    }
}
