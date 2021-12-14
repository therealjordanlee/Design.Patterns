using Abstract.Factory.Implementation;

// Melbourne Pizza Shop
var melbourneIngredientFactory = new MelbourneIngredientFactory();
new CheesePizza(melbourneIngredientFactory).Bake();

// Sydney Pizza Shop
var SydneyIngredientFactory = new SydneyIngredientFactory();
new CheesePizza(SydneyIngredientFactory).Bake();
