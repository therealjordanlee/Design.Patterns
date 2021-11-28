using Strategy.Implementation;
using Strategy.Pattern;

var quackers = new List<IQuacker>
{
    new MuteQuack(),
    new SqueakQuack(),
    new StandardQuack()
};

var ducks = new List<Duck>
{
    new MallardDuck(quackers),
    new MandarinDuck(quackers),
    new HarlequinDuck(quackers),
    new RubberDuck(quackers),
    new WoodenDuck(quackers)
};

foreach(var duck in ducks)
{
    duck.PerformQuack();
}