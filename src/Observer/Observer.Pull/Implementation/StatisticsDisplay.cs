using Observer.Pull.Pattern;

namespace Observer.Pull.Implementation
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private WeatherData _weatherData;
        private Random _random;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
            _random = new Random();
        }

        public void Display()
        {
            var minTemperature = _random.NextDouble() * -9 + _temperature;
            var maxTemperature = _random.NextDouble() * 9 + _temperature;
            var averageTemperature = (minTemperature + maxTemperature) / 2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Avg/Max/Min: {averageTemperature.ToString("n1")}/{maxTemperature.ToString("n1")}/{minTemperature.ToString("n1")}");
        }

        public void Update()
        {
            _temperature = _weatherData.Temperature;
            Display();
        }
    }
}
