using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public class Coffee : IBeverage
    {

        private int _cost;

        public Coffee (int newCost)
        {

            _cost = newCost;

        }

        public int GetCost()
        {
            return _cost;
        }


        public string GetDescription()
        {
            return "Coffee";
        }



    }
}
