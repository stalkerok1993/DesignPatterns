using WeatherORama.Display;

namespace WeatherORama.WeatherData
{
    interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}
