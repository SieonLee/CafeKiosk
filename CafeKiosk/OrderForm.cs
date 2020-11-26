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
           // UCCoffeeOption uCCoffeeOption = new UCCoffeeOption();
           // uCCoffeeOption.ReturnCoffeeMenu += UCCoffeeOption_ReturnCoffeeMenu;
            
        }

        private void UCCoffee_CoffeeSelected(object sender, UCCoffee.CoffeeSelectedEventArgs e)
        {
            movesidepanel(btnCoffee);
            UCCoffeeOption uCCoffeeOption = new UCCoffeeOption();
            addUC(uCCoffeeOption);
            uCCoffeeOption.ReturnCoffeeMenu += UCCoffeeOption_ReturnCoffeeMenu;
        } 
        
        //private void UCCoffeeOption(object sender, EventArgs e)
        //{
        //    // UCCoffeeOption uCCoffeeOption = new UCCoffeeOption();
        //    //uCCoffeeOption.ReturnCoffeeMenu += UCCoffeeOption_ReturnCoffeeMenu;
        //    //addUC(uCCoffeeOption);
        //    //UCCoffeeOption uCCoffeeOption = new UCCoffeeOption();
        //   // uCCoffeeOption.ReturnCoffeeMenu += UCCoffeeOption_ReturnCoffeeMenu;
        //    UCCoffee uCCoffee = new UCCoffee();
        //    addUC(uCCoffee);
        //}
        private void UCCoffeeOption_ReturnCoffeeMenu(object sender, UCCoffeeOption.ReturnCoffeeMenuEventArgs e)
        {
            //UCCoffeeOption uCCoffeeOption = new UCCoffeeOption();
            //addUC(uCCoffeeOption);
            //UCCoffee uCCoffee = new UCCoffee();
            //addUC(uCCoffee);
            btnCoffee.PerformClick();
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
            uCDessert.DessertSelected += UCDessert_DessertSelected;
            addUC(uCDessert);
        }

        private void UCDessert_DessertSelected(object sender, UCDessert.DessertSelectedEventArgs e)
        {
            UCDessertOption uCDessertOption = new UCDessertOption();
            addUC(uCDessertOption);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            movesidepanel(btnCart);
            UCCartt uCCart = new UCCartt();
            addUC(uCCart);
        }

        
    }
}