namespace Singleton.Pattern
{
    public class ClassicSingleton
    {
        private static ClassicSingleton _classicSingleton;
        private static string _singletonValue;

        private ClassicSingleton()
        {
            _singletonValue = Guid.NewGuid().ToString(); // Guid is also itself follows the Singleton pattern.
        }


        public static ClassicSingleton GetInstance()
        {
            if (_classicSingleton == null)
                _classicSingleton = new ClassicSingleton();
                
            return _classicSingleton;
        }

        public void PrintValue()
        {
            Console.WriteLine($"Value: {_singletonValue}");
        }
    }
}
