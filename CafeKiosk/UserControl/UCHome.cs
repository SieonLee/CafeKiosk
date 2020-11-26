using System;
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

    
        internal void bntTakeout_Click(object sender, EventArgs e)
        {
            //MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            //DialogResult result = MessageBox.Show(message1, title, buttons);
          
            //if (result == DialogResult.OK)
            //{
              
            //    MessageBox.Show("확인");
            //    OrderForm order = new OrderForm();
            //}

        }

        internal void btnNoTakeOut_Click(object sender, EventArgs e)
        {
            //MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            //DialogResult result = MessageBox.Show(message2, title, buttons);
            //if (result == DialogResult.OK)
            //{
            //    //UCHome.takeout = false;
            //}
        }
    }
}

