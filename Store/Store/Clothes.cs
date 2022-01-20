using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Clothes : Product
    {
        
        public Size Size {get; private set; }

        public string Color { get; private set; } 

        public Clothes(string name, string brand, decimal price,Size size,string color ) : base(name, brand, price)
        {
            
            this.Size = size;
            this.Color = color;
            
        }
        public override decimal HasDiscount()
        {
            decimal discountPercent = 0;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(DateTime.Now);
            if (day > DayOfWeek.Sunday || day < DayOfWeek.Saturday)
            {
                discountPercent = 10;
            }
            return discountPercent;
        }

        public override string AdditionalInfo()
        {
            string sizeColor = Size.ToString()+" "+Color.ToString();
            return sizeColor;
        }
    }
    public enum Size
    {
        XS,
        S,
        M,
        L,
        XL
    }
}
