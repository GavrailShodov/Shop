using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Food : Product
    {

        public DateTime ExpirationDate { get; private set; }
        
        public Food ( string name, string brand, decimal price, DateTime dateTime) :base( name,  brand,  price)
        {
            this.ExpirationDate = dateTime;
        }

        public override decimal HasDiscount()
        {
            var fiveDays= DateTime.Now.AddDays(-5);
            decimal discountpercent = 0;
            if(DateTime.Today == this.ExpirationDate.Date)
            {
                discountpercent = 50;
            }
            else if(DateTime.Today < this.ExpirationDate && DateTime.Today >= fiveDays)
            {
                discountpercent = 10;
            }
            
            return discountpercent;
        }
    }
}
