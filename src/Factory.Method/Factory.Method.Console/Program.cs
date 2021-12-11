using Factory.Method.Implementation;
using Factory.Method.Pattern;

var melbourneStore = new MelbournePizzaStore();
melbourneStore.OrderPizza(PizzaType.Cheese);
melbourneStore.OrderPizza(PizzaType.Ham);

var sydneyStore = new SydneyPizzaStore();
sydneyStore.OrderPizza(PizzaType.Cheese);
sydneyStore.OrderPizza(PizzaType.Ham);