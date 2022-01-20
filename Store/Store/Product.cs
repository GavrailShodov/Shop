using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        public string Name { get; private set; }
        public string Brand { get; private set; }

        public decimal Price { get; private set; }

        public Product(string name, string brand, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }


        public abstract decimal HasDiscount();

        public virtual string AdditionalInfo()
        {
            return null;
        }
        
    }
}
