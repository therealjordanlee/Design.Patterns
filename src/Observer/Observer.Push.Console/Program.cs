using Observer.Push.Implementation;

var weatherData = new WeatherData();
var currentDisplay = new CurrentConditionsDisplay();
var statisticDisplay = new StatisticsDisplay();

weatherData.RegisterObserver(currentDisplay);
weatherData.RegisterObserver(statisticDisplay);

// This will cause all observers to update
weatherData.SetMeasurements((float)10, (float)1.2, (float)3.0);