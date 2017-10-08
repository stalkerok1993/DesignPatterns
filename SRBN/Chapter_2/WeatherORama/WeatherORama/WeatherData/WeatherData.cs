using System.Collections.Generic;
using WeatherORama.Display;

namespace WeatherORama.WeatherData
{
    class WeatherData : IWeatherSubject
    {
        private List<IWeatherObserver> observers;

        public float Pressure
        {
            get;
        }

        public float Humidity
        {
            get;
        }

        public float Temperature
        {
            get;
        }

        public void NotifyObserver()
        {
            foreach (IWeatherObserver o in observers)
            {
                o.Update(this);
            }
        }

        public void RegisterObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
