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
    public partial class UCJuiceOption : UserControl
    {
        int quantity = 1;
        public UCJuiceOption()
        {
            InitializeComponent();
            lblQuantity.Text = quantity.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OnReturnJuiceMenu(true);
        }

        #region ReturnJuiceMenu event things for C# 3.0
        public event EventHandler<ReturnJuiceMenuEventArgs> ReturnJuiceMenu;

        protected virtual void OnReturnJuiceMenu(ReturnJuiceMenuEventArgs e)
        {
            if (ReturnJuiceMenu != null)
                ReturnJuiceMenu(this, e);
        }

        private ReturnJuiceMenuEventArgs OnReturnJuiceMenu(bool returnJuice)
        {
            ReturnJuiceMenuEventArgs args = new ReturnJuiceMenuEventArgs(returnJuice);
            OnReturnJuiceMenu(args);

            return args;
        }

        private ReturnJuiceMenuEventArgs OnReturnJuiceMenuForOut()
        {
            ReturnJuiceMenuEventArgs args = new ReturnJuiceMenuEventArgs();
            OnReturnJuiceMenu(args);

            return args;
        }

        public class ReturnJuiceMenuEventArgs : EventArgs
        {
            public bool ReturnJuice { get; set; }

            public ReturnJuiceMenuEventArgs()
            {
            }

            public ReturnJuiceMenuEventArgs(bool returnJuice)
            {
                ReturnJuice = returnJuice;
            }
        }
        #endregion

        private void btnToCart_Click(object sender, EventArgs e)
        {
            OnReturnJuiceMenu(true);
        }


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

        

        private void btnTall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIce_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
