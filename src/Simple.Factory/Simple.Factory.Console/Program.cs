using Simple.Factory.Implementation;

var pizzaFactory = new SimplePizzaFactory();
var cheesePizza = pizzaFactory.Create(PizzaType.Cheese);
cheesePizza.Prepare();
cheesePizza.Cook();

var pepperoniPizza = pizzaFactory.Create(PizzaType.Pepperoni);
pepperoniPizza.Prepare();
pepperoniPizza.Cook();
