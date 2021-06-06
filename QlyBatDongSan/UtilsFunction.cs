using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBatDongSan
{
    class UtilsFunction
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

        public decimal ConvertCurrencyToDecimal(string TextNumber)
        {
            return decimal.Parse(TextNumber.Replace(",", ""));
        }

        public string ConvertCurrency(decimal number)
        {
            return String.Format(culture, "{0:N0}", number);
        }
        public void ConvertCurrency(TextBox textbox)
        {
            try
            {
                decimal number = decimal.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", number);
                textbox.Select(textbox.Text.Length, 0);
            }
            catch
            {
                textbox.Text = "0";
            }

        }
        public void ConvertCurrency(TextBox textbox, ref decimal number)
        {
            try
            {
                number = decimal.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", number);
                textbox.Select(textbox.Text.Length, 0);
            }
            catch
            {
                textbox.Text = "0";
            }

        }
    }
}
