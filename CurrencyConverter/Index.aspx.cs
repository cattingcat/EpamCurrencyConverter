using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class Index : System.Web.UI.Page
    {
        private ICurrencyData _currencyData;

        public Index()
        {
            _currencyData = new CurrenciesData();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string s in _currencyData.GetCurrencies())
                {
                    srcCurrency.Items.Add(s);
                    destCurrency.Items.Add(s);
                }
            }

            decimal srcCrc = _currencyData.GetCourceToDollar(srcCurrency.SelectedItem.Text);
            srcCourse.Text = srcCrc.ToString();

            decimal destCrc = _currencyData.GetCourceToDollar(destCurrency.SelectedItem.Text);
            destCourse.Text = destCrc.ToString();
        }

        protected void calc_Click(object sender, EventArgs e)
        {
            decimal srcCrs = decimal.Parse(srcCourse.Text);
            decimal destCrs = decimal.Parse(destCourse.Text);

            decimal srcInDollar = decimal.Parse(srcSum.Text) * srcCrs;
            decimal destSum = srcInDollar / destCrs;

            resultString.Text = String.Format("{0} {1} = {2:0.00} {3}", srcSum.Text, srcCurrency.SelectedItem.Text, destSum, destCurrency.SelectedItem.Text);
        }
    }
}