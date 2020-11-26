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
    }
}
