namespace Template.Method.Pattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        internal void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }

        internal void PourInCup()
        {
            Console.WriteLine($"Pouring {this.GetType().Name} into a cup.");
        }

        abstract internal void Brew();
        abstract internal void AddCondiments();

        /// <summary>
        /// This is known as a 'Hook':
        /// A method declared in an abstract class with a default implementation.
        /// Subclasses can 'hook into' (override) the implementation to alter the flow
        /// of the algorithm in the Template class.
        /// </summary>
        /// <returns></returns>
        internal virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
