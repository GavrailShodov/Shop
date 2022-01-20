using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Appliance : Product
    {
        public string Model { get; private set; }

        public DateTime ProductionDate { get; private set; }

        public decimal Weight { get; private set; }

        public Appliance(string name, string brand, decimal price,string model, DateTime dateTime, decimal weight) : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = dateTime;
            this.Weight = weight;
        }

        public override decimal HasDiscount()
        {
            decimal discountPercent = 0;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(DateTime.Now);
            if ((day == DayOfWeek.Sunday || day==DayOfWeek.Saturday)&& this.Price>999)
            {
                discountPercent = 5;
            }
                return discountPercent;
        }

        public override string AdditionalInfo()
        {
            string model = this.Model.ToString();
            return model;
        }

    }
}
