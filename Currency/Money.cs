using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    
    internal class Money
    {
        public Money() { }

        public int cents { get; set; }

        public void AddCents( int cent)
        {
           cents = cents + cent;
        }
    }
}
