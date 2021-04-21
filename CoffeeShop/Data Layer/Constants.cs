using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public class Constants
    {

        public const int TeaCost = 78;
        public const int CoffeeCost = 100;
        public const int CaramelCost = 56;
        public const int CreamCost = 50;
        public const int HoneyCost = 45;
        public const int ChocolateCost = 30;

        public static string SelectItemMenu = $"Select :\n1.Tea      {TeaCost} \n2.Coffee   {CoffeeCost}\n";
        public static string SelectAddOnsMenu = $"\n\nSelect :\n1. Caramel    {CaramelCost}  \n2. Chocolate  {ChocolateCost} \n3. Cream      {CreamCost} \n4. Honey      {HoneyCost} \n0.Exit\n";
        
        public const string DefaultTeaDescription = "Tea";
        public const string DefaultCoffeeDescription = "Coffee";
        public const string AddOnsMenuInstruction = "Press 1 or 2 or 3 or 4 Respectively and press 0 to exit.\n";
        public const string ItemMenuInstruction = "Press 1 or 2 respectively.";
        public const string MenuItemWrongChoice = "Input is out of range.";
        public const string AddOnItemWrongChoice = "Add-On is out of range.";
        public const string AnyOtherChoice = "\nDo you want any other Add-On ?";

        public const char IncorrectInput = '$';

    }
}
