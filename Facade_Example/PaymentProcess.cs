using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Example
{
    internal class PaymentProcess
    {
        public bool HandlePayment ( double amount , string visaInfo)
        {
            return true;
        }
    }
}
