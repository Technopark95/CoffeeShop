using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Menu
    {


        // using private field prefixed with _ and camelCase

       private IBeverage _menuItem;
       private char _choice;
       private int _totalCost;
       private string _description;

     

        public void SelectItem()
        {

            Console.WriteLine(Constants.SelectItemMenu);
         

            this._choice = Console.ReadKey().KeyChar;

            if (_choice == '1')
            {
                _menuItem = new Tea(Constants.TeaCost);

                _totalCost = Constants.TeaCost;

                _description = Constants.DefaultTeaDescription;


            }


            if (_choice == '2')
            {
                _menuItem = new Coffee(Constants.CoffeeCost);

                _totalCost = Constants.CoffeeCost;

                _description = Constants.DefaultCoffeeDescription;
            }


        }


        public void SelectAddOns()
        {

            Console.WriteLine(Constants.SelectAddOnsMenu);
          

                while (true)
                {

                    char Choice = Console.ReadKey().KeyChar;

                    Console.Write(" -> ");

                    if (Choice == 'A' || Choice == 'a')
                    {

                        Caramel Custom = new Caramel(_menuItem, Constants.CaramelCost);

                        _menuItem = Custom;

                        Console.WriteLine("Status : " + _menuItem.GetDescription());


                }

                    if (Choice == 'B' || Choice == 'b')
                    {

                        Chocolate Custom = new Chocolate(_menuItem, Constants.ChocolateCost);
                        _menuItem = Custom;
                        Console.WriteLine("Status : " + _menuItem.GetDescription());

                    }

                    if (Choice == 'C' || Choice == 'c')
                    {

                        Cream Custom = new Cream(_menuItem, Constants.CreamCost);

                        _menuItem = Custom;
                        Console.WriteLine("Status : " + _menuItem.GetDescription());
                    }

                    if (Choice == 'D' || Choice == 'd')
                    {

                        Honey Custom = new Honey(_menuItem, Constants.HoneyCost);

                        _menuItem = Custom;

                        Console.WriteLine("Status : " + _menuItem.GetDescription());

                    }


                    if (Choice == '9')
                    {

                        break;

                    }


                _totalCost = _menuItem.GetCost();
                _description = _menuItem.GetDescription();

            }





        }

        public int GetCost()
        {
            return _totalCost;

        }

        public string GetDescription()
        {
            return _description;
        }


    }
}
