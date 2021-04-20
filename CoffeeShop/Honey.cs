using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Honey : BeverageDecorator
    {
        private Beverage BeverageType;
        private int AddOnCost;


        public Honey(Beverage TypeofBeverage, int CostOfAddOn)
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
            return BeverageType.GetDescription() + " topped with Honey";
        }
    }
}
