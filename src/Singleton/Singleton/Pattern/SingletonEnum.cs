namespace Singleton.Pattern
{
    public enum SingletonEnum
    {
        UNIQUE_INSTANCE
    }

    public static class SingletonEnumExtension
    {
        private static string _singletonValue;

        public static void PrintValue(this SingletonEnum singletonEnum)
        {
            if(string.IsNullOrEmpty(_singletonValue))
                _singletonValue = Guid.NewGuid().ToString();

            Console.WriteLine($"Value: {_singletonValue}");
        }
    }
}
