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
        int quantity = 1;
        public UCDessertOption()
        {
            InitializeComponent();
            lblQuantity.Text = quantity.ToString();
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

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity == 0)
            {
                quantity = 1;
            }
            quantity -= 1;
            lblQuantity.Text = quantity.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            quantity += 1;
            lblQuantity.Text = quantity.ToString();
        }

        bool isChecked = false;
        private void btnCreamLess_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = btnCreamLess.Checked;
        }
        private void btnCreamLess_Click(object sender, EventArgs e)
        {
            if (btnCreamLess.Checked && !isChecked)
            {
                btnCreamLess.Checked = false;
            }
            else
            {
                btnCreamLess.Checked = true;
                isChecked = false;
            }
        }

        private void btnCreamMore_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = btnCreamLess.Checked;
        }

        private void btnCreamMore_Click(object sender, EventArgs e)
        {
            if (btnCreamMore.Checked && !isChecked)
            {
                btnCreamMore.Checked = false;
            }
            else
            {
                btnCreamMore.Checked = true;
                isChecked = false;
            }
        }

        private void btnAddIceC_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = btnAddIceC.Checked;
        }

        private void btnAddIceC_Click(object sender, EventArgs e)
        {
            if (btnAddIceC.Checked && !isChecked)
            {
                btnAddIceC.Checked = false;
            }
            else
            {
                btnAddIceC.Checked = true;
                isChecked = false;
            }
        }

        private void btnAddFork_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = btnAddFork.Checked;
        }

        private void btnAddFork_Click(object sender, EventArgs e)
        {
            if (btnAddFork.Checked && !isChecked)
            {
                btnAddFork.Checked = false;
            }
            else
            {
                btnAddFork.Checked = true;
                isChecked = false;
            }
        }
    }
}
