using Decorator.Pattern;

namespace Decorator.Implementation
{
    public class HouseBlend : Beverage
    {
        public override float Cost()
        {
            return 3;
        }

        public override string Description()
        {
            return "House Blend";
        }
    }

    public class Espresso : Beverage
    {
        public override float Cost()
        {
            return 2.5f;
        }

        public override string Description()
        {
            return "Espresso";
        }
    }
}
