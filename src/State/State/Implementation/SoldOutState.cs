using State.Pattern;

namespace State.Implementation
{
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public StateType Type => StateType.SoldOut;

        public void Dispense()
        {
            PrintError();
        }

        public void EjectQuarter()
        {
            PrintError();
        }

        public void InsertQuarter()
        {
            PrintError();
        }

        private void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: OUT OF GUMBALLS");
            Console.ResetColor();
        }
    }
}
