namespace Facade.Implementation
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier: On");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier: Off");
        }

        public void SetVolumeLevel(int volumeLevel)
        {
            Console.WriteLine($"Amplifier: Volume set to {volumeLevel}");
        }
    }
}
