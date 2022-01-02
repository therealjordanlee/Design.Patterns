using State.Implementation;

var gumballMachine = new GumballMachine();

gumballMachine.InsertQuarter();
gumballMachine.EjectQuarter();

for (int i = 0; i < 11; i++)
{
    gumballMachine.InsertQuarter();
    gumballMachine.Dispense();
}
gumballMachine.InsertQuarter();
gumballMachine.EjectQuarter();
