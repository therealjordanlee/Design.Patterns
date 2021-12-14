using Abstract.Factory.Pattern;

namespace Abstract.Factory.Implementation
{
    public class MelbourneIngredientFactory : AbstractIngredientFactory
    {
        public override string CreateCheese()
        {
            return "Mozzarella Cheese";
        }

        public override string CreateDough()
        {
            return "Thin Crust Dough With Cheese Filling";
        }
    }
}
