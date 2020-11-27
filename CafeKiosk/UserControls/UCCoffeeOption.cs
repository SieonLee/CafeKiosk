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
    public partial class UCCoffeeOption : UserControl 
    {
         int quantity = 1;
        public UCCoffeeOption()
        {
            InitializeComponent();
            lblQuantity.Text = quantity.ToString();
        }

      
        internal void btnReturn_Click(object sender, EventArgs e)
        {
            OnReturnCoffeeMenu(true);
            
        }


        #region ReturnCoffeeMenu event things for C# 3.0
        public event EventHandler<ReturnCoffeeMenuEventArgs> ReturnCoffeeMenu;

        protected virtual void OnReturnCoffeeMenu(ReturnCoffeeMenuEventArgs e)
        {
            if (ReturnCoffeeMenu != null)
                ReturnCoffeeMenu(this, e);
        }

        private ReturnCoffeeMenuEventArgs OnReturnCoffeeMenu(bool returnCoffee)
        {
            ReturnCoffeeMenuEventArgs args = new ReturnCoffeeMenuEventArgs(returnCoffee);
            OnReturnCoffeeMenu(args);

            return args;
        }

        private ReturnCoffeeMenuEventArgs OnReturnCoffeeMenuForOut()
        {
            ReturnCoffeeMenuEventArgs args = new ReturnCoffeeMenuEventArgs();
            OnReturnCoffeeMenu(args);

            return args;
        }

        public class ReturnCoffeeMenuEventArgs : EventArgs
        {
            public bool ReturnCoffee { get; set; }

            public ReturnCoffeeMenuEventArgs()
            {
            }

            public ReturnCoffeeMenuEventArgs(bool returnCoffee)
            {
                ReturnCoffee = returnCoffee;
            }
        }
        #endregion

        private void btnToCart_Click(object sender, EventArgs e)
        {
            OnReturnCoffeeMenu(true);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(quantity == 0)
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
    }
}