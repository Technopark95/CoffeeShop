using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
     class Caramel : BeverageDecorator
    {
       
       private Beverage BeverageType;
       private  int AddOnCost;
  

        public Caramel(Beverage TypeofBeverage , int CostOfAddOn)
        {
     
            BeverageType = TypeofBeverage;
            AddOnCost = CostOfAddOn; 
            
        }


        public override int GetCost()
        {
           

            return BeverageType.GetCost() + AddOnCost;

        }

        public override string GetDescription()
        {
            return BeverageType.GetDescription() + " topped with Caramel";
        }
    }
}
