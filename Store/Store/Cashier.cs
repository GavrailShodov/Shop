using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier 
    {
        public static void PrintReceipt(Cart cart,DateTime purchaseTime)
        {
            decimal subTotal = 0;
            decimal allDiscounts = 0;

            Console.WriteLine("Date:" + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("--Products--");
            Console.WriteLine();

            foreach (Product products in cart.products)
            {
                    var productId = cart.products.IndexOf(products);
                    Console.WriteLine(products.Name + " " + products.Brand+" "+products.AdditionalInfo());
                    decimal price = (decimal)cart.quantitys[productId] * products.Price;
                    Console.WriteLine(cart.quantitys[productId] + " x $" + products.Price + " = $" + price);
                if (products.HasDiscount() != 0)
                {
                    decimal discount = price * (products.HasDiscount() / 100);
                    Console.WriteLine("#discount " + products.HasDiscount() + "% -$" + discount);
                    allDiscounts += discount;
                }
                    Console.WriteLine();
                    subTotal += price;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("SUBTOTAL: ${0}",subTotal);
            Console.WriteLine("DISCOUNT: -${0}", allDiscounts);
            Console.WriteLine();
            Console.WriteLine("TOTAL: ${0}", subTotal - allDiscounts);


            Console.ReadKey();

        }
    }
}
