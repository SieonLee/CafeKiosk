using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class UCCoffee : UserControl
    {
        
        public UCCoffee()
        {
            InitializeComponent();
        }


        private void btnEspresso_Click(object sender, EventArgs e)
        {
            OnCoffeeSelected(true);
        }
        private void btnCara_Click(object sender, EventArgs e)
        {
            OnCoffeeSelected(false);
        }

        private void btnMoc_Click(object sender, EventArgs e)
        {

        }

        private void btnLatte_Click(object sender, EventArgs e)
        {

        }

        private void btnDol_Click(object sender, EventArgs e)
        {

        }

        #region CoffeeSelected event things for C# 3.0
        public event EventHandler<CoffeeSelectedEventArgs> CoffeeSelected;

        protected virtual void OnCoffeeSelected(CoffeeSelectedEventArgs e)
        {
            if (CoffeeSelected != null)
                CoffeeSelected(this, e);
        }

        private CoffeeSelectedEventArgs OnCoffeeSelected(bool coffeeOptionSelected)
        {
            CoffeeSelectedEventArgs args = new CoffeeSelectedEventArgs(coffeeOptionSelected);
            OnCoffeeSelected(args);

            return args;
        }

        private CoffeeSelectedEventArgs OnCoffeeSelectedForOut()
        {
            CoffeeSelectedEventArgs args = new CoffeeSelectedEventArgs();
            OnCoffeeSelected(args);

            return args;
        }

        public class CoffeeSelectedEventArgs : EventArgs
        {
            public bool CoffeeOptionSelected { get; set; }

            public CoffeeSelectedEventArgs()
            {
            }

            public CoffeeSelectedEventArgs(bool coffeeOptionSelected)
            {
                CoffeeOptionSelected = coffeeOptionSelected;
            }
        }
        #endregion

       
    }
}
