using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Menu
    {

       private dynamic _MenuItem;
       private char _Choice;
       private int _TotalCost;
       private string _Description;

     

        public void SelectItem()
        {

            Console.WriteLine(Constants.SelectItemMenu);
         

            this._Choice = Console.ReadKey().KeyChar;

            if (_Choice == '1')
            {
                _MenuItem = new Tea(Constants.TeaCost);

                _TotalCost = Constants.TeaCost;

                _Description = "Tea";


            }


            if (_Choice == '2')
            {
                _MenuItem = new Coffee(Constants.CoffeeCost);

                _TotalCost = Constants.CoffeeCost;

                _Description = "Coffee";
            }


        }


        public void SelectAddOns()
        {

            Console.WriteLine(Constants.SelectAdonsMenu);

          

                while (true)
                {

                    char Choice = Console.ReadKey().KeyChar;

                    if (Choice == 'A' || Choice == 'a')
                    {

                        dynamic Custom = new Caramel(_MenuItem, Constants.CaramelCost);

                        _MenuItem = Custom;

                        Console.WriteLine("Status : " + _MenuItem.GetDescription());


                }

                    if (Choice == 'B' || Choice == 'b')
                    {

                        dynamic Custom = new Chocolate(_MenuItem, Constants.ChocolateCost);
                        _MenuItem = Custom;
                        Console.WriteLine("Status : " + _MenuItem.GetDescription());

                    }

                    if (Choice == 'C' || Choice == 'c')
                    {

                        dynamic Custom = new Cream(_MenuItem, Constants.CreamCost);

                        _MenuItem = Custom;
                        Console.WriteLine("Status : " + _MenuItem.GetDescription());
                    }

                    if (Choice == 'D' || Choice == 'd')
                    {

                        dynamic Custom = new Honey(_MenuItem, Constants.HoneyCost);

                        _MenuItem = Custom;

                        Console.WriteLine("Status : " + _MenuItem.GetDescription());

                    }


                    if (Choice == '9')
                    {

                        break;

                    }


                _TotalCost = _MenuItem.GetCost();
                _Description = _MenuItem.GetDescription();

            }





        }

        public int GetCost()
        {
            return _TotalCost;

        }

        public string GetDescription()
        {
            return _Description;
        }


    }
}
