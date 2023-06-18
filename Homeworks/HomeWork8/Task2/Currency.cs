using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Currency
    {

        public ECurrency CurrencyLabel { get; set; }
        public decimal Amount { get; set; }

    }

    public enum ECurrency
    {
        USD ,
        GEL ,
        EUR 
    }
}
