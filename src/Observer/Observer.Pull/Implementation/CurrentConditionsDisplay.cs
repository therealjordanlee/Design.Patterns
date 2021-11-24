using Observer.Pull.Pattern;

namespace Observer.Pull.Implementation
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current Conditions: {_temperature.ToString("n1")} degrees; {_humidity.ToString("n1")}% humidity");
        }

        public void Update()
        {
            _temperature = _weatherData.Temperature;
            _humidity = _weatherData.Humidity;
            Display();
        }
    }
}
