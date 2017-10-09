using System.Collections.Generic;
using WeatherORama.Display;

namespace WeatherORama.WeatherData
{
    class WeatherObject : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        public float Pressure
        {
            get;
            private set;
        }

        public float RelativeHumidity
        {
            get;
            private set;
        }

        public float Temperature
        {
            get;
            private set;
        }

        protected void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(this);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Used to simulate data changes.
        /// </summary>
        /// <param name="relativeHumidity">Relative humidity fraction (from 0 to 1). NOT percents.</param>
        public void SetMeasurements(float temperature, float relativeHumidity, float pressure)
        {
            Temperature = temperature;
            RelativeHumidity = relativeHumidity;
            Pressure = pressure;
            NotifyObservers();
        }
    }
}
