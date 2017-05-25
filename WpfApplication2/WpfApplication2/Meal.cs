using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    [Serializable()]
    class Meal
    {
        string name;
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        int value;
        public int Value
        {
            get
            {
                return this.value;
            }
        }

        public int amountConsumed = 0;
        public int AmountConsumed
        {
            get
            {
                return this.amountConsumed;
            }
        }
        public DateTime dateConsumed;
        public String DateConsumed
        {
            get
            {
                return this.dateConsumed.ToShortDateString();
            }
        }

        public double Total
        {
            get
            {
                return 1.0 * this.amountConsumed * this.value / 100;
            }
        }

        public Meal(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
        
    }
}
