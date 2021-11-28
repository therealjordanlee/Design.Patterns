using Strategy.Pattern;

namespace Strategy.Implementation
{
    public class StandardQuack : IQuacker
    {
        public List<Type> SupportedDucks => new List<Type> { typeof(MandarinDuck), typeof(MallardDuck), typeof(HarlequinDuck) };

        public void Quack()
        {
            Console.Write("Quack!");
        }
    }
}