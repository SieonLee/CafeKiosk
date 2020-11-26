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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            movesidepanel(btnStart);
            //UCHome uCHome = new UCHome();
            //addUC(uCHome);
            
            
        }
        private void movesidepanel(Button btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
            
        }

        private void addUC(UserControl uc) //User Control 생성
        {
            panelCenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(uc);
        }

        internal void btnStart_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(UCHome._passFlag.ToString());
            movesidepanel(btnStart);
            UCHome uCHome = new UCHome();
            addUC(uCHome);
          

        }
        
        
        internal void btnCoffee_Click(object sender, EventArgs e)
        {
            movesidepanel(btnCoffee);
            UCCoffee uCCoffee = new UCCoffee();
            addUC(uCCoffee);
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            movesidepanel(btnJuice);
            UCJuice uCJuice = new UCJuice();
            addUC(uCJuice);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            movesidepanel(btnDessert);
            UCDessert uCDessert = new UCDessert();
            addUC(uCDessert);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            movesidepanel(btnCart);
            UCCartt uCCart = new UCCartt();
            addUC(uCCart);
        }
    }
}
