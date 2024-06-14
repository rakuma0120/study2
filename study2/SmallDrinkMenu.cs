using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    public class SmallDrinkMenu : DrinkMenu
    {
        public SmallDrinkMenu(string name, string description, int price, bool iscold) : base(name, description, price, iscold)
        {
        }
    }
}
