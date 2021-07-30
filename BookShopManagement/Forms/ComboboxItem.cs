using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Forms
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboboxItem(string texto, int valor)
        {
            this.Text = texto;
            this.Value = valor;
        }
    }
}
