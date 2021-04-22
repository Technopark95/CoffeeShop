using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    [Beverage]
    abstract class BeverageDecorator : IBeverage
    {
        public abstract int GetCost();
        public abstract string GetDescription();
    }
}
