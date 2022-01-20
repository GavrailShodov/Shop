using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cart
    {
        public List<Product> products { get; private set; }
        public List<double> quantitys { get; private set; }

        public Cart()
        {
            this.products = new List<Product>();
            this.quantitys = new List<double>(); 
        }

        public void Add(Product item,double quantity)
        {
            products.Add(item);
            quantitys.Add(quantity);
        }


    }
}
