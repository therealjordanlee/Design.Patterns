using Abstract.Factory.Pattern;

namespace Abstract.Factory.Implementation
{
    public class SydneyIngredientFactory : AbstractIngredientFactory
    {
        public override string CreateCheese()
        {
            return "Rotten Cheese";
        }

        public override string CreateDough()
        {
            return "Mud and Sand Dough";
        }
    }
}
