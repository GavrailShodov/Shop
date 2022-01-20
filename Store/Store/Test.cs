using System;

namespace Store
{ 
    public class Test
    {
        static void Main(string[] args)
        {
            Product product = new Food("Apple","Barnd1",(decimal)3.14,DateTime.Now);
            var quantity = 2;
            Cart cart = new Cart();
            cart.Add(product,quantity);

            Product product1 = new Clothes("Cloth", "Brand2", (decimal)6, Size.S,"red");
            var quantity1 = 3;
            
            cart.Add(product1, quantity1);

            Cashier.PrintReceipt(cart, DateTime.Now);
        }
    }
}