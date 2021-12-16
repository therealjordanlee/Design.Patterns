using Command.Implementation.Receivers;
using Command.Pattern;

namespace Command.Implementation.Commands
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
