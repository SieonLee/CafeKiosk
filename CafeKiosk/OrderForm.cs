using CafeKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFLibrary;


namespace CafeKiosk
{
    public partial class OrderForm : Form
    {
        private Order _order;

        public OrderForm()
        {
            InitializeComponent();

            movesidepanel(btnStart);
            UCHome uCHome = new UCHome();
            uCHome.TakeOutSelected += UCHome_TakeOutSelected;
            addUC(uCHome);
        }

        private void start()
        {
            
            if (_order == null)
            {
                _order = new Order();
                _order.TakeOut = true;
                _order.OrderedAt = DateTime.Today;
                _order.Total = 0;
                Dao.Order.Insert(_order);

                _order = Dao.Order.GetByPK(Dao.Order.GetMaxKey());
                
            }
            else
            {
                //_order.Total++;
                //Dao.Order.Update(_order);
            }
        }
        int count = Dao.Order.GetMaxKey();
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
            start();

            movesidepanel(btnCoffee);

            //orderID 넘겨주기, orderLineID생성해서 넘겨주기
            UCCoffee uCCoffee = new UCCoffee((count + 1)); //orderId넘겨줌orderLineId_
            uCCoffee.CoffeeSelected += UCCoffee_CoffeeSelected;
            addUC(uCCoffee);

        }

        private void UCCoffee_CoffeeSelected(object sender, UCCoffee.CoffeeSelectedEventArgs e)
        {

            int _orderidid = Dao.OrderLine.GetMaxKey(); //orderlineID
            MessageBox.Show(_orderidid.ToString());
            movesidepanel(btnCoffee);
            UCCoffeeOption uCCoffeeOption = new UCCoffeeOption(_orderidid); //orderlineid넘겨줌
            addUC(uCCoffeeOption);
            uCCoffeeOption.ReturnCoffeeMenu += UCCoffeeOption_ReturnCoffeeMenu;

        }

        private void UCCoffeeOption_ReturnCoffeeMenu(object sender, UCCoffeeOption.ReturnCoffeeMenuEventArgs e)
        {
            btnCoffee.PerformClick();
        }



        private void btnJuice_Click(object sender, EventArgs e)
        {

            start();
            movesidepanel(btnCoffee);


            //orderID 넘겨주기, orderLineID생성해서 넘겨주기
            movesidepanel(btnJuice);
            UCJuice uCJuice = new UCJuice((count+1));
            uCJuice.JuiceSelected += UCJuice_JuiceSelected;
            addUC(uCJuice);

        }

        private void UCJuice_JuiceSelected(object sender, UCJuice.JuiceSelectedEventArgs e)
        {

            int _orderidid = Dao.OrderLine.GetMaxKey(); //orderlineID
            MessageBox.Show(_orderidid.ToString());
            movesidepanel(btnJuice);
            UCJuiceOption uCJuiceOption = new UCJuiceOption(_orderidid);
            uCJuiceOption.ReturnJuiceMenu += UCJuiceOption_ReturnJuiceMenu;
            addUC(uCJuiceOption);
        }

        private void UCJuiceOption_ReturnJuiceMenu(object sender, UCJuiceOption.ReturnJuiceMenuEventArgs e)
        {
            btnJuice.PerformClick();
        }


        private void btnDessert_Click(object sender, EventArgs e)
        {
            start();
            movesidepanel(btnDessert);


            //orderID 넘겨주기, orderLineID생성해서 넘겨주기
            UCDessert uCDessert = new UCDessert((count + 1)); //orderId넘겨줌orderLineId_
            uCDessert.DessertSelected += UCDessert_DessertSelected;
            addUC(uCDessert);



        }

        private void UCDessert_DessertSelected(object sender, UCDessert.DessertSelectedEventArgs e)
        {
            int _orderidid = Dao.OrderLine.GetMaxKey(); //orderlineID
            MessageBox.Show(_orderidid.ToString());
            movesidepanel(btnDessert);
            UCDessertOption uCDessertOption = new UCDessertOption(_orderidid); //orderlineid넘겨줌
            addUC(uCDessertOption);
            uCDessertOption.ReturnDessertMenu += UCDessertOption_ReturnDessertMenu;
        }

        private void UCDessertOption_ReturnDessertMenu(object sender, UCDessertOption.ReturnDessertMenuEventArgs e)
        {
            btnDessert.PerformClick();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            movesidepanel(btnCart);
            UCCartt uCCart = new UCCartt();
            uCCart.MovePrevSelected += UCCart_MovePrevSelected;
            addUC(uCCart);
        }

        private void UCCart_MovePrevSelected(object sender, UCCartt.MovePrevSelectedEventArgs e)
        {
            btnCoffee.PerformClick();
        }
    }
}
