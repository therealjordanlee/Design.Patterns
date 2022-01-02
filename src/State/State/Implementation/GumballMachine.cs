using State.Pattern;

namespace State.Implementation
{
    /// <summary>
    /// GumballMachine represents a state machine (object with several possible states).
    /// </summary>
    public class GumballMachine
    {
        public IEnumerable<IState> States { get; }
        private IState _currentState;
        private int _count;

        public GumballMachine()
        {
            States = new List<IState>
            {
                new HasQuarterState(this),
                new NoQuarterState(this),
                new SoldOutState(this)
            };

            _currentState = States.First(x => x.Type == StateType.NoQuarter);
            _count = 10;
        }

        public void InsertQuarter()
        {
            _currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _currentState.EjectQuarter();
        }

        public void Dispense()
        {
            _currentState.Dispense();
            if(_count > 0)
                _count--;

        }

        public void SetState(IState state)
        {
            _currentState=state;
        }

        public int GetRemainingGumballs()
        {
            return _count;
        }
    }
}
