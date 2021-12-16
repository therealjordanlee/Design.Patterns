using Command.Implementation.Receivers;
using Command.Pattern;

namespace Command.Implementation.Commands
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}
