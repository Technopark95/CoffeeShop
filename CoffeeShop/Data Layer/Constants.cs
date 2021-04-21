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
        public static string SelectAddOnsMenu = $"\n\nSelect :\nA.Caramel    {CaramelCost}  \nB.Chocolate  {ChocolateCost} \nC.Cream      {CreamCost} \nD.Honey      {HoneyCost} \n9.Exits\n";
        public const string DefaultTeaDescription = "Tea";
        public const string DefaultCoffeeDescription = "Coffee";



    }
}
