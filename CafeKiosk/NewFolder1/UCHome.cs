using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        string message1 = "포장을 선택하셨습니다";
        string message2 = "매장이용을 선택하셨습니다";
        string title = "포장여부";

        bool takeout = false;

        private void bntTakeout_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message1, title, buttons);
            if (result == DialogResult.OK)
            {
                takeout = true;
            }
        }

        private void btnNoTakeOut_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message2, title, buttons);
            if (result == DialogResult.OK)
            {
                takeout = false;
            }
        }
    }
}
