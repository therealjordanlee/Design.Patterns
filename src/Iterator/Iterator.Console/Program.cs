using Iterator.Implementation;
using Iterator.Pattern;

var lunchMenu = new LunchMenu();
var lunchMenuIterator = lunchMenu.CreateIterator();
PrintMenu(lunchMenuIterator);

var dinnerMenu = new DinnerMenu();
var dinnerMenuIterator = dinnerMenu.CreateIterator();
PrintMenu(dinnerMenuIterator);

void PrintMenu(IIterator iterator)
{
    while(iterator.HasNext())
    {
        var item = iterator.Next();
        Console.WriteLine($"{item.Name}: {item.Description}   ${item.Price}");
    }    
}