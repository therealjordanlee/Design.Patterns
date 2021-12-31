using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Pattern;

namespace Composite.Implementation
{
    /// <summary>
    /// Menu is the composite class.
    /// It may hold other menus, or MenuItems.
    /// </summary>
    public class Menu : AbstractMenuComponent
    {
        private List<AbstractMenuComponent> _menuItems;
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
            _menuItems = new List<AbstractMenuComponent>();
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Add(AbstractMenuComponent component)
        {
            _menuItems.Add(component);
        }

        public override void Remove(AbstractMenuComponent component)
        {
            _menuItems.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine(_name);
            Console.WriteLine(_description);
            Console.WriteLine("=====");
            foreach(var menu in _menuItems)
            {
                menu.Print();
            }
        }
    }
}
