using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{


[AttributeUsage(AttributeTargets.All)]
 public class BeverageAttribute : System.Attribute
   {
  
      
}

    [Beverage]
    abstract class BeverageDecorator : Beverage
    {
        public abstract int getCost();
        public abstract string getDescription();
    }


}
