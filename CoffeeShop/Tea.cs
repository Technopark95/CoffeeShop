using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public class Tea : Beverage
    {

        private int cost;

        public Tea(int Newcost)
        {

            cost = Newcost;

        }


        public int GetCost()
        {
            return cost;
        }


        public string GetDescription()
        {

            return "Tea";

        }

    }
}
