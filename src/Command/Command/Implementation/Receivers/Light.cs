namespace Command.Implementation.Receivers
{
    public class Light
    {
        private string _name;

        public Light(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{_name} ");
            Console.ResetColor();
            Console.Write("was turned ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("on\n");
            Console.ResetColor();
        }

        public void Off()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{_name} ");
            Console.ResetColor();
            Console.Write("was turned ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("off\n");
            Console.ResetColor();
        }
    }
}
