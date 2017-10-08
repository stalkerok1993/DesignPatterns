using WeatherORama.Display;

namespace WeatherORama.WeatherData
{
    interface IWeatherSubject
    {
        void RegisterObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObserver();

        float Pressure { get; }
        float Humidity { get; }
        float Temperature { get; }
    }
}
