using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu MenuItem = new Menu();

                MenuItem.SelectItem();

                MenuItem.SelectAddOns();

                Console.WriteLine("\n"); // 2 line spacing

                Console.WriteLine("Total Cost : " + MenuItem.GetCost());
                Console.WriteLine("Total Description : " + MenuItem.GetDescription());

                Console.WriteLine(Constants.ThankYouMessage);
            }
            catch (Exception Except)
            {
                Console.WriteLine(Except.Message);
            }

            Console.ReadKey();
        }
    }
}
