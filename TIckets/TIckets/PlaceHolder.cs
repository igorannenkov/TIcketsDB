using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TIckets
{
    public static class PlaceHolderManager
    {
        public static void AddPlaceHolder(this TextBox tb, string placeholderText)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = placeholderText;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholderText)
                {
                    tb.Text = tb.Text = String.Empty;
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (tb.Text == String.Empty)
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = placeholderText;
                }
            };
        }
    }
}
