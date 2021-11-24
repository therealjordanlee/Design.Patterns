using Observer.Push.Pattern;

namespace Observer.Push.Implementation
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current Conditions: {_temperature.ToString("n1")} degrees; {_humidity.ToString("n1")}% humidity");
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
