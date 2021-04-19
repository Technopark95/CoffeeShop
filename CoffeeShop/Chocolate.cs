﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Chocolate : BeverageDecorator
    {
        private Beverage BeverageType;
        private int AddOnCost;


        public Chocolate(Beverage TypeofBeverage, int CostOfAddOn)
        {

            BeverageType = TypeofBeverage;
            AddOnCost = CostOfAddOn;

        }


        public override int getCost()
        {

            return BeverageType.getCost() + AddOnCost;

        }

        public override string getDescription()
        {
            return BeverageType.getDescription() + " topped with Chocolate";
        }
    }
}
