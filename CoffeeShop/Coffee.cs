using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public class Coffee : Beverage
    {

        private int cost;

        public Coffee (int Newcost)
        {

            cost = Newcost;

        }

        public int getCost()
        {
            return cost;
        }


        public string getDescription()
        {
            return "Coffee";
        }



    }
}
