using Decorator.Implementation;

var houseBlend = new HouseBlend();
var houseBlendWithCondiments = new Soy(new Mocha(new Milk(houseBlend)));
Console.WriteLine($"{houseBlendWithCondiments.Description()}: {houseBlendWithCondiments.Cost()}");

var espresso = new Espresso();
var espressoWithCondiments = new Mocha(new Milk(new Soy(espresso)));
Console.WriteLine($"{espressoWithCondiments.Description()}: {espressoWithCondiments.Cost()}");