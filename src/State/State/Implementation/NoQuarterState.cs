using State.Pattern;

namespace State.Implementation
{
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public StateType Type => StateType.NoQuarter;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please insert coin");
            Console.ResetColor();
        }

        public void EjectQuarter()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You must insert coin first");
            Console.ResetColor();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Coin has been inserted");
            _gumballMachine.SetState(_gumballMachine.States.First(x => x.Type == StateType.HasQuarter));
        }
    }
}
