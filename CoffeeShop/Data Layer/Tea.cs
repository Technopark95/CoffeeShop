using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public class Tea : IBeverage
    {

        private int _cost;

        //Using parameters as camelCase provided in the Decoumentation
        public Tea(int newCost)     
        {

            _cost = newCost;

        }


        public int GetCost()
        {
            return _cost;
        }


        public string GetDescription()
        {

            return "Tea";

        }

    }
}
