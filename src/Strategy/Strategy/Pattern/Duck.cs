namespace Strategy.Pattern
{
    /// <summary>
    /// This represents the clients (different type of Ducks).
    /// </summary>
    public abstract class Duck
    {
        private List<IQuacker> _quackingStrategies;

        public Duck(List<IQuacker> quackingStrategies)
        {
            _quackingStrategies = quackingStrategies;
        }

        public virtual void PerformQuack()
        {
            var strategy = _quackingStrategies.FirstOrDefault(x => x.SupportedDucks.Contains(this.GetType()));
            if (strategy == null)
                throw new NotImplementedException();
            Console.Write($"I am a {this.GetType().Name}: ");
            strategy.Quack();
            Console.WriteLine();
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck(List<IQuacker> quackingStrategies) : base(quackingStrategies)
        {
        }
    }

    public class MandarinDuck : Duck
    {
        public MandarinDuck(List<IQuacker> quackingStrategies) : base(quackingStrategies)
        {
        }
    }

    public class HarlequinDuck : Duck
    {
        public HarlequinDuck(List<IQuacker> quackingStrategies) : base(quackingStrategies)
        {
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck(List<IQuacker> quackingStrategies) : base(quackingStrategies)
        {
        }
    }

    public class WoodenDuck : Duck
    {
        public WoodenDuck(List<IQuacker> quackingStrategies) : base(quackingStrategies)
        {
        }
    }
}