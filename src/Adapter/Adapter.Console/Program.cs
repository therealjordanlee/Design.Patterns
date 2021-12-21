using Adapter.Implementation;

var wildTurkey = new WildTurkey();
var turkeyAdapter = new TurkeyAdapter(wildTurkey);

turkeyAdapter.Quack();
turkeyAdapter.Fly();