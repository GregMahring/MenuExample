using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Fall2016
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu ourMenu = new Menu("Carl the car");

            int menuOption = 1;

            do
            {
                if (menuOption == 1)
                {
                    Console.WriteLine("Please enter an item to purchase.");
                    string itemToPurchase = Console.ReadLine();
                    ourMenu.PurchaseItem(itemToPurchase);
                }
                else if (menuOption == 2)
                {
                    ourMenu.DisplayCart();
                }
                else if (menuOption == 3)
                {
                    ourMenu.TotalPrice(true);
                }

                Console.WriteLine("Please enter a number to select one of the following menu items.");
                Console.WriteLine("1. Enter an item to purchase\n2. Display the contents of your cart\n3. Display the total price of the cart");
                Console.WriteLine("Or choose any other number to quit.");

                menuOption = int.Parse(Console.ReadLine());

            } while (menuOption < 4 && menuOption > 0);

        }
    }
}
