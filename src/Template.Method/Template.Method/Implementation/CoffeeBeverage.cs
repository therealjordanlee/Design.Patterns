using Template.Method.Pattern;

namespace Template.Method.Implementation
{
    public class CoffeeBeverage : CaffeineBeverage
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("Add a teaspoon of sugar and milk.");
        }

        internal override void Brew()
        {
            Console.WriteLine("Drip the coffee through filter.");
        }
    }
}
