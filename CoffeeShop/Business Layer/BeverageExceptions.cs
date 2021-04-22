using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class BeverageExceptions : Exception
    {
        public void MenuItemInputException()
        {
            Console.WriteLine(Constants.MenuItemWrongChoice);
        }
        public void AddOnItemInputException()
        {
            Console.WriteLine(Constants.AddOnItemWrongChoice);
        }
    }
}
