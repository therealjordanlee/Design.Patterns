using Observer.Pull.Pattern;

namespace Observer.Pull.Implementation
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        public float Temperature { get; internal set; }
        public float Humidity { get; internal set; }
        public float Pressure { get; internal set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update());
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
