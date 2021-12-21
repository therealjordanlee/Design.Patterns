namespace Facade.Implementation
{
    public class MediaPlayer
    {
        public void On()
        {
            Console.WriteLine("MediaPlayer: On");
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine($"MediaPlayer: Now playing {movie}");
        }

        public void Off()
        {
            Console.WriteLine("MediaPlayer: Off");
        }
    }
}
