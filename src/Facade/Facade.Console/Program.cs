using Facade.Implementation;

var amplifier = new Amplifier();
var mediaPlayer = new MediaPlayer();
var popcornPopper = new PopcornPopper();
var projector = new Projector();
var screen = new Screen();

var homeTheatre = new HomeTheatreFacade(amplifier, popcornPopper, projector, screen, mediaPlayer);

homeTheatre.WatchMovie("The Godfather");
homeTheatre.EndMovie();