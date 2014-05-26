using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyConverter
{
    public interface ICurrencyData
    {
        IEnumerable<string> GetCurrencies();
        decimal GetCourceToDollar(string valute);
    }
}