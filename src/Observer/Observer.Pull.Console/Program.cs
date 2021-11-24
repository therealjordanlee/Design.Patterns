using Observer.Pull.Implementation;

var weatherData = new WeatherData();
var currentDisplay = new CurrentConditionsDisplay(weatherData);
var statisticDisplay = new StatisticsDisplay(weatherData);

// This will cause all observers to update
weatherData.SetMeasurements((float)10, (float)1.2, (float)3.0);