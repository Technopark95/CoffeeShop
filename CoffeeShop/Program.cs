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

            Tea tea = new Tea(78);

            dynamic Customization = new Caramel(tea, 56);

     
            Customization = new Cream(Customization, 50);

            Customization = new Honey(Customization, 45);



            Console.WriteLine("Total Cost : " + Customization.getCost());

            Console.WriteLine("Description : " + Customization.getDescription());


            //Chocolate TeaWith2CaramelplusChocolate = new Chocolate(TeaWithDoubleCaramel, 50);

            //Honey TeaWithCarameWithCh = new Honey(TeaWithCaramel, 56);


            //Console.WriteLine("Cost : " + TeaWithCarameWithCh.getCost());

            //Console.WriteLine("Description : " + TeaWithCarameWithCh.getDescription());

            //Console.WriteLine("Cost : " + TeaWith2CaramelplusChocolate.getCost());

            //Console.WriteLine("Description : " +TeaWith2CaramelplusChocolate.getDescription());


            Console.ReadKey();

        }
    }
}
