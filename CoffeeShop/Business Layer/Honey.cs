﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Honey : BeverageDecorator
    {
        private IBeverage _BeverageType;
        private int _AddOnCost;


        public Honey(IBeverage TypeOfBeverage, int CostOfAddOn)
        {

            _BeverageType = TypeOfBeverage;
            _AddOnCost = CostOfAddOn;

        }


        public override int GetCost()
        {

            return _BeverageType.GetCost() + _AddOnCost;

        }

        public override string GetDescription()
        {
            return _BeverageType.GetDescription() + " topped with Honey";
        }
    }
}
