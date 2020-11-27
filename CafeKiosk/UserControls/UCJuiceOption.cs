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
        public UCJuiceOption()
        {
            InitializeComponent();
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


        private void btnTall_Click(object sender, EventArgs e)
        {

        }
    }
}
