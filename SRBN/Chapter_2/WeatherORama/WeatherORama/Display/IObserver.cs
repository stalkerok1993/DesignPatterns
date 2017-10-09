using WeatherORama.WeatherData;

namespace WeatherORama.Display
{
    interface IObserver
    {
        void Update(IObservable subject);
    }
}
