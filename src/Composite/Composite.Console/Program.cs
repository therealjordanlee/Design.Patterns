using Composite.Implementation;

var lunchMenu = new Menu("Lunch Menu", "Served from 12pm-5pm daily");
lunchMenu.Add(new MenuItem("Chicken Sandwich", "Dead bird with 2 slices of bread.", 12));
lunchMenu.Add(new MenuItem("Beef Sandwich", "Butchered cow with a side of bread.", 15));

var dinnerMenu = new Menu("Dinner Menu", "Server from 5pm-11pm daily");
dinnerMenu.Add(new MenuItem("Chicken Rice", "Dead bird in a bowl of rice", 20));
dinnerMenu.Add(new MenuItem("Wagyu Beef", "A slaughtered cow, still dripping with blood", 50));

// The composite (menu) consists of both other composites (lunchMenu & dinnerMenu) as well as leaf nodes.
var menu = new Menu("Jordan's Diner", "Enjoy our selection of quality food");
menu.Add(lunchMenu);
menu.Add(dinnerMenu);
menu.Add(new MenuItem("Water", "Fresh from the tap", 2));

menu.Print();