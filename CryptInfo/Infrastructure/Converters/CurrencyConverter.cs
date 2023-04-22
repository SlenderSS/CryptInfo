using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptInfo.Infrastructure.Converters
{
    class CurrencyConverter : Converter
    {

        private const short THOUSAND = 1000;
        private const uint MILLION = 1000000;
        private const uint BILLION = 1000000000;
        private const ulong TRIILLION = 1000000000000;

        private const string DOLLAR_SYMBOL = "$";

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is double currency)) return null;

            double convertedCurrency;
            if(currency > TRIILLION)
            {
                convertedCurrency = currency / TRIILLION;
                return string.Join("", DOLLAR_SYMBOL, $"{convertedCurrency:0.00}", "T");
            }
            else if(currency > BILLION)
            {
                convertedCurrency = currency / BILLION;
                return string.Join("", DOLLAR_SYMBOL, $"{convertedCurrency:0.00}", "B");
            }
            else if (currency > MILLION)
            {
                convertedCurrency = currency / MILLION;
                return string.Join("", DOLLAR_SYMBOL, $"{convertedCurrency:0.00}", "M");
            }
            else if (currency > THOUSAND)
            {
                convertedCurrency = currency / THOUSAND;
                return string.Join("", DOLLAR_SYMBOL, $"{convertedCurrency:0.00}", "K");
            }
            else
            {
                return string.Join("", DOLLAR_SYMBOL, $"{currency:0.00}", "K");
            }
            
        }
    }
}
