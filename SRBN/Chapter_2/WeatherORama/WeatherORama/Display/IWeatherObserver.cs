using WeatherORama.WeatherData;

namespace WeatherORama.Display
{
    interface IWeatherObserver
    {
        void Update(IWeatherSubject subject);
    }
}
