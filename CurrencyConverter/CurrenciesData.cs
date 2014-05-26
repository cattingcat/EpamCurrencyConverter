using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyConverter
{
    public class CurrenciesData: ICurrencyData
    {
        private IDictionary<string, decimal> _cources;

        public CurrenciesData()
        {
            _cources = new Dictionary<string, decimal>();
            _cources.Add("$", 1M);
            _cources.Add("Ru", 30.5M);
            _cources.Add("Frank", 1.1M);
            _cources.Add("Eu", 0.89M);
            _cources.Add("Jpy", 122.5M);
        }

        public IEnumerable<string> GetCurrencies()
        {
            return _cources.Keys;
        }

        public decimal GetCourceToDollar(string valute)
        {
            return _cources[valute];
        }
    }
}