using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
   public  class MenuInput
    {

     public  char SelectItemInput()
        {


            char Choice = ' ';

            try {

             Choice = Console.ReadKey().KeyChar;


                if (Choice != '1' && Choice != '2')
            {
                throw new BeverageExceptions();
            }

            } catch(BeverageExceptions e)
            {

                e.MenuItemInputException();

                Console.ReadKey();

                Environment.Exit(-1);

            }

            return Choice;

        }

        public char SelectAddOnInput()

        {
            char Choice = ' ';

            try
            {

                Choice = Console.ReadKey().KeyChar;

                bool NotValidInput = Choice != '1' && Choice != '2' 
                                     && Choice != '3' && Choice != '4' 
                                     && Choice != '0';

                if (NotValidInput)
                {

                    throw new BeverageExceptions();

                }

            }
            catch (BeverageExceptions e)
            {

                e.AddOnItemInputException();

                return '$';

            }

            return Choice;

        }



    }
}
