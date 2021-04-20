﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Honey : BeverageDecorator
    {
        private IBeverage _beverageType;
        private int _addOnCost;


        public Honey(IBeverage typeOfBeverage, int costOfAddOn)
        {

            _beverageType = typeOfBeverage;
            _addOnCost = costOfAddOn;

        }


        public override int GetCost()
        {


            return _beverageType.GetCost() + _addOnCost;

        }

        public override string GetDescription()
        {
            return _beverageType.GetDescription() + " topped with Honey";
        }
    }
}
