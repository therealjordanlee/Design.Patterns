using State.Pattern;

namespace State.Implementation
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public StateType Type => StateType.HasQuarter;

        public void Dispense()
        {
            if(_gumballMachine.GetRemainingGumballs() > 0)
            {
                Console.WriteLine("Gumball dispensed");
                _gumballMachine.SetState(_gumballMachine.States.First(x => x.Type == StateType.NoQuarter));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: OUT OF GUMBALLS");
                Console.ResetColor();
                _gumballMachine.SetState(_gumballMachine.States.First(x => x.Type == StateType.SoldOut));
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Coin ejected");
            _gumballMachine.SetState(_gumballMachine.States.First(x => x.Type == StateType.NoQuarter));
        }

        public void InsertQuarter()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No space for another coin...");
            Console.ResetColor();
        }
    }
}
