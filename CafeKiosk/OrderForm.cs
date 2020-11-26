﻿using System;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            movesidepanel(btnStart);
            UCHome uCHome = new UCHome();
            uCHome.TakeOutSelected += UCHome_TakeOutSelected;
            addUC(uCHome);
        }


        private void UCHome_TakeOutSelected(object sender, UCHome.TakeOutSelectedEventArgs e)
        {
            btnCoffee.PerformClick();
        }
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            movesidepanel(btnCoffee);
            UCCoffee uCCoffee = new UCCoffee();
            uCCoffee.CoffeeSelected += UCCoffee_CoffeeSelected;
            addUC(uCCoffee);
        }

        private void UCCoffee_CoffeeSelected(object sender, UCCoffee.CoffeeSelectedEventArgs e)
        {
            UCCoffeeOption uCCoffeeOption = new UCCoffeeOption();
            addUC(uCCoffeeOption);
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
