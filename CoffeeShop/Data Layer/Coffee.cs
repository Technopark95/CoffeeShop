using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public class Coffee : IBeverage
    {

        private int Cost;

        public Coffee (int NewCost)
        {

            Cost = NewCost;

        }

        public int GetCost()
        {
            return Cost;
        }


        public string GetDescription()
        {
            return "Coffee";
        }



    }
}
