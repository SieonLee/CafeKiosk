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
    public partial class UCJuice : UserControl
    {
        public UCJuice()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void btnJamongAde_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void btnLemonAde_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void btnLemonTea_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void btnMango_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void btnFlane_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        private void btnBlueBerry_Click(object sender, EventArgs e)
        {
            OnJuiceSelected(true);
        }

        #region JuiceSelected event things for C# 3.0
        public event EventHandler<JuiceSelectedEventArgs> JuiceSelected;

        protected virtual void OnJuiceSelected(JuiceSelectedEventArgs e)
        {
            if (JuiceSelected != null)
                JuiceSelected(this, e);
        }

        private JuiceSelectedEventArgs OnJuiceSelected(bool juiceOptionSelected)
        {
            JuiceSelectedEventArgs args = new JuiceSelectedEventArgs(juiceOptionSelected);
            OnJuiceSelected(args);

            return args;
        }

        private JuiceSelectedEventArgs OnJuiceSelectedForOut()
        {
            JuiceSelectedEventArgs args = new JuiceSelectedEventArgs();
            OnJuiceSelected(args);

            return args;
        }

        public class JuiceSelectedEventArgs : EventArgs
        {
            public bool JuiceOptionSelected { get; set; }

            public JuiceSelectedEventArgs()
            {
            }

            public JuiceSelectedEventArgs(bool juiceOptionSelected)
            {
                JuiceOptionSelected = juiceOptionSelected;
            }
        }
        #endregion
    }
}
