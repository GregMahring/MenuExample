using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Fall2016
{
    class Menu
    {
        //fields
        private List<string> shoppingCart;
        private string userName;
        private string billingInfo;
        private double cartPrice;

        //properties
        public string UserName
        {
            get { return this.userName; }
            set {
                    if (value.Length > 4)
                    {
                        this.userName = value;
                    }
                }
        }

        public string BillingInfo
        {
            get { return this.billingInfo; }
            set { this.billingInfo = value; }
        }

        public string DeliveryInfo
        {
            get;
            set;
        }

        //constructors
        public Menu(string userName)
        {
            this.userName = userName;
            shoppingCart = new List<string>();
        }


        //methods
        public void PurchaseItem(string itemName)
        {
            double itemPrice = itemName.Length * 10;
            cartPrice += itemPrice;
            shoppingCart.Add(itemName + ": $" + itemPrice);
        }

        public void DisplayCart()
        {
            foreach (string item in shoppingCart)
            {
                Console.WriteLine(item);
            }
            TotalPrice(true);
        }

        public double TotalPrice(bool display)
        {
            if (display)
            {
                Console.WriteLine("Total Price: $" + cartPrice);
            }

            return cartPrice;
        }

    }
}
