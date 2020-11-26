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
        public UCCoffeeOption()
        {
            InitializeComponent();
        }

        //private void btnReturn_Click(object sender, EventArgs e)
        //{
            
        //}
      

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

    }
}