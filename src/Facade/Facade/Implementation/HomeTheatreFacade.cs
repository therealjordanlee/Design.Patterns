using Facade.Pattern;

namespace Facade.Implementation
{
    public class HomeTheatreFacade : IHomeTheatreFacade
    {
        private Amplifier _amplifier;
        private PopcornPopper _popcornPopper;
        private Projector _projector;
        private Screen _screen;
        private MediaPlayer _mediaPlayer;

        public HomeTheatreFacade(Amplifier amplifier, PopcornPopper popcornPopper, Projector projector, Screen screen, MediaPlayer mediaPlayer)
        {
            _amplifier = amplifier;
            _popcornPopper = popcornPopper;
            _projector = projector;
            _screen = screen;
            _mediaPlayer = mediaPlayer;
        }

        public void WatchMovie(string movie)
        {
            _screen.On();
            _projector.On();
            _popcornPopper.On();
            _amplifier.On();
            _mediaPlayer.On();

            _popcornPopper.Start();
            _mediaPlayer.PlayMovie(movie);
        }

        public void EndMovie()
        {
            _screen.Off();
            _projector.Off();
            _popcornPopper.Off();
            _amplifier.Off();
            _mediaPlayer.Off();
        }
    }
}
