using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Enum
{
    public struct CurrencyExchange
    {

        public double Exchange(Currency currency,double azn)
        {
            if (currency==Currency.USD)
            {
                return azn * 0.59;
            }
            else if (currency == Currency.EUR)
            {
                return azn * 0.56;
            }
            else if (currency == Currency.TRY)
            {
                return azn * 11;
            }
            else
            {
                return azn * 36;
            }
        }

    }
}
