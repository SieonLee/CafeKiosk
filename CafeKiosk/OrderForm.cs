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
        public OrderForm()
        {
            InitializeComponent();

            movesidepanel(btnStart);
            UCHome uCHome = new UCHome();
            uCHome.TakeOutSelected += UCHome_TakeOutSelected;

            addUC(uCHome);
        }

        Order _order = new Order();
        //public OrderForm(Order order) : this()
        //{
        //  _order = order;
        //}
        //     private Order _order;



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
            //MessageBox.Show(_order.OrderID.ToString());

            //    MessageBox.Show(_order.OrderID.ToString()); //오더 순번 보여줌


            btnCoffee.PerformClick();
            //  }
        }
        private void btnCoffee_Click(object sender, EventArgs e)
        {

            int count = Dao.Order.GetCount();
            Order _order = new Order();
            _order.OrderID = count + 1;
            _order.TakeOut = true;
            _order.OrderedAt = DateTime.Today;
            _order.Total = 0;
            Dao.Order.Insert(_order);
            Dao.Order.Update(_order);

            movesidepanel(btnCoffee);

            //orderID 넘겨주기, orderLineID생성해서 넘겨주기
            UCCoffee uCCoffee = new UCCoffee(Dao.Order.GetCount());
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

        private void UCCoffeeOption_ReturnCoffeeMenu(object sender, UCCoffeeOption.ReturnCoffeeMenuEventArgs e)
        {

            btnCoffee.PerformClick();
        }



        private void btnJuice_Click(object sender, EventArgs e)
        {
            movesidepanel(btnJuice);
            UCJuice uCJuice = new UCJuice();
            uCJuice.JuiceSelected += UCJuice_JuiceSelected;
            addUC(uCJuice);

        }

        private void UCJuice_JuiceSelected(object sender, UCJuice.JuiceSelectedEventArgs e)
        {
            movesidepanel(btnJuice);
            UCJuiceOption uCJuiceOption = new UCJuiceOption();
            uCJuiceOption.ReturnJuiceMenu += UCJuiceOption_ReturnJuiceMenu;
            addUC(uCJuiceOption);
        }

        private void UCJuiceOption_ReturnJuiceMenu(object sender, UCJuiceOption.ReturnJuiceMenuEventArgs e)
        {
            btnJuice.PerformClick();
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
