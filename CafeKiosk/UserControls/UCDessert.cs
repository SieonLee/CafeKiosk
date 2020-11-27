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
    public partial class UCDessert : UserControl
    {
        public UCDessert()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnDessertSelected(true);
        }

        private void btnTiramisu_Click(object sender, EventArgs e)
        {
            OnDessertSelected(true);
        }

        private void btnHoney_Click(object sender, EventArgs e)
        {
            OnDessertSelected(true);
        }

        private void btnMacaron_Click(object sender, EventArgs e)
        {
            OnDessertSelected(true);
        }

        private void btnWaffle_Click(object sender, EventArgs e)
        {
            OnDessertSelected(true);
        }

        private void btnCroffle_Click(object sender, EventArgs e)
        {
            OnDessertSelected(true);
        }

        #region DessertSelected event things for C# 3.0
        public event EventHandler<DessertSelectedEventArgs> DessertSelected;

        protected virtual void OnDessertSelected(DessertSelectedEventArgs e)
        {
            if (DessertSelected != null)
                DessertSelected(this, e);
        }

        private DessertSelectedEventArgs OnDessertSelected(bool dessertOptionSelected)
        {
            DessertSelectedEventArgs args = new DessertSelectedEventArgs(dessertOptionSelected);
            OnDessertSelected(args);

            return args;
        }

        private DessertSelectedEventArgs OnDessertSelectedForOut()
        {
            DessertSelectedEventArgs args = new DessertSelectedEventArgs();
            OnDessertSelected(args);

            return args;
        }

        public class DessertSelectedEventArgs : EventArgs
        {
            public bool DessertOptionSelected { get; set; }

            public DessertSelectedEventArgs()
            {
            }

            public DessertSelectedEventArgs(bool dessertOptionSelected)
            {
                DessertOptionSelected = dessertOptionSelected;
            }
        }
        #endregion
    }
}
