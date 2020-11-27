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
    public partial class UCDessertOption : UserControl
    {
        int counter = 1;
        public UCDessertOption()
        {
            InitializeComponent();
        }

        private void btnCountDwn_Click(object sender, EventArgs e)
        {
            counter--;
            lblQuantity.Text = counter.ToString();
        }

        private void btnCountUp_Click(object sender, EventArgs e)
        {
            counter++;
            lblQuantity.Text = counter.ToString();
        }

        private void btnWhipLess_Click(object sender, EventArgs e)
        {
            btnWhipLess.BackColor = Color.Beige;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OnReturnDessertMenu(true);
        }

        #region ReturnDessertMenu event things for C# 3.0
        public event EventHandler<ReturnDessertMenuEventArgs> ReturnDessertMenu;

        protected virtual void OnReturnDessertMenu(ReturnDessertMenuEventArgs e)
        {
            if (ReturnDessertMenu != null)
                ReturnDessertMenu(this, e);
        }

        private ReturnDessertMenuEventArgs OnReturnDessertMenu(bool returnDessert)
        {
            ReturnDessertMenuEventArgs args = new ReturnDessertMenuEventArgs(returnDessert);
            OnReturnDessertMenu(args);

            return args;
        }

        private ReturnDessertMenuEventArgs OnReturnDessertMenuForOut()
        {
            ReturnDessertMenuEventArgs args = new ReturnDessertMenuEventArgs();
            OnReturnDessertMenu(args);

            return args;
        }

        public class ReturnDessertMenuEventArgs : EventArgs
        {
            public bool ReturnDessert { get; set; }

            public ReturnDessertMenuEventArgs()
            {
            }

            public ReturnDessertMenuEventArgs(bool returnDessert)
            {
                ReturnDessert = returnDessert;
            }
        }
        #endregion
    }
}
