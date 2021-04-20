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


            //Tea tea = new Tea(TeaCost);

            //dynamic Customization = new Caramel(tea, CaramelCost);

            //Customization = new Cream(Customization, CreamCost);

            //Customization = new Honey(Customization, HoneyCost);

            //Console.WriteLine("Total Cost : " + Customization.GetCost());

            //Console.WriteLine("Description : " + Customization.GetDescription());


            Menu MenuItem = new Menu();

            MenuItem.SelectItem();

            MenuItem.SelectAddOns();

            Console.WriteLine("Total Cost : " + MenuItem.GetCost());

            Console.WriteLine("Total Description : " + MenuItem.GetDescription());

            Console.ReadKey();


        }
    }
}
