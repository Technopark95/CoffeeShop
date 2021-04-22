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
            Console.WriteLine(Constants.ItemMenuInstruction);
            MenuInput TakeInput = new MenuInput();
            do
            {
                _choice = TakeInput.SelectItemInput();
            }
            while (_choice == '$');
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
            MenuInput TakeInput = new MenuInput();
            Console.WriteLine(Constants.SelectAddOnsMenu);
            Console.WriteLine(Constants.AddOnsMenuInstruction);
            while (true)
            {
                char Choice = TakeInput.SelectAddOnInput();
                if (Choice == Constants.IncorrectInput) continue;
                Console.Write(" -> ");
                if (Choice == '1')
                {
                    Caramel Custom = new Caramel(_menuItem, Constants.CaramelCost);
                    _menuItem = Custom;
                    Console.WriteLine("Status : " + _menuItem.GetDescription());
                }
                if (Choice == '2')
                {
                    Chocolate Custom = new Chocolate(_menuItem, Constants.ChocolateCost);
                    _menuItem = Custom;
                    Console.WriteLine("Status : " + _menuItem.GetDescription());
                }
                if (Choice == '3')
                {
                    Cream Custom = new Cream(_menuItem, Constants.CreamCost);
                    _menuItem = Custom;
                    Console.WriteLine("Status : " + _menuItem.GetDescription());
                }
                if (Choice == '4')
                {
                    Honey Custom = new Honey(_menuItem, Constants.HoneyCost);
                    _menuItem = Custom;
                    Console.WriteLine("Status : " + _menuItem.GetDescription());
                }
                if (Choice == '0')
                {
                    Console.WriteLine("Exit");
                    break;
                }
                _totalCost = _menuItem.GetCost();
                _description = _menuItem.GetDescription();
                Console.WriteLine(Constants.AnyOtherChoice);
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
