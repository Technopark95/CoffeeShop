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

       private dynamic _menuItem;
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

                _description = "Tea";


            }


            if (_choice == '2')
            {
                _menuItem = new Coffee(Constants.CoffeeCost);

                _totalCost = Constants.CoffeeCost;

                _description = "Coffee";
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

                        dynamic Custom = new Caramel(_menuItem, Constants.CaramelCost);

                        _menuItem = Custom;

                        Console.WriteLine("Status : " + _menuItem.GetDescription());


                }

                    if (Choice == 'B' || Choice == 'b')
                    {

                        dynamic Custom = new Chocolate(_menuItem, Constants.ChocolateCost);
                        _menuItem = Custom;
                        Console.WriteLine("Status : " + _menuItem.GetDescription());

                    }

                    if (Choice == 'C' || Choice == 'c')
                    {

                        dynamic Custom = new Cream(_menuItem, Constants.CreamCost);

                        _menuItem = Custom;
                        Console.WriteLine("Status : " + _menuItem.GetDescription());
                    }

                    if (Choice == 'D' || Choice == 'd')
                    {

                        dynamic Custom = new Honey(_menuItem, Constants.HoneyCost);

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
