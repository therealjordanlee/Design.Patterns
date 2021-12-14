using Abstract.Factory.Pattern;

namespace Abstract.Factory.Implementation
{
    public class CheesePizza : BasePizza
    {
        public CheesePizza(AbstractIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }

        public override void Bake()
        {
            _cheese = _ingredientFactory.CreateCheese();
            _dough = _ingredientFactory.CreateDough();

            Console.WriteLine($"Baked a {this.GetType().Name} with the following ingredients:");
            Console.WriteLine(_cheese);
            Console.WriteLine(_dough);
            Console.WriteLine();
        }
    }
}
