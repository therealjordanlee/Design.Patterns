using Observer.Push.Pattern;

namespace Observer.Push.Implementation
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private Random _random;

        public StatisticsDisplay()
        {
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

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
