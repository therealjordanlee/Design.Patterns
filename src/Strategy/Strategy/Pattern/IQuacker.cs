namespace Strategy.Pattern
{
    /// <summary>
    /// This interface represents the family of algorithms.
    /// </summary>
    public interface IQuacker
    {
        public List<Type> SupportedDucks { get; }
        void Quack();
    }
}