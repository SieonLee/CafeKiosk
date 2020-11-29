using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeKiosk.Data;

namespace CafeKiosk
{
    public partial class UCCoffee : UserControl
    {
        //OrderLine orderLine = new OrderLine();

        public UCCoffee()
        {
            InitializeComponent();
        }
        public UCCoffee(int order) : this()
        {
            _orderLine.OrderID = order;
        }


        //private OrderLine _orderLine;
        OrderLine _orderLine = new OrderLine();
        public void OptionClick() //함수 만들어야함
        {
            _orderLine.OrderLineID = 1;
            Dao.OrderLine.Insert(_orderLine);
            OnCoffeeSelected(true);//커피를 눌렀을때 옵션 패널 호출
        }


        private void btnEspresso_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 1;
            OptionClick();
        }
        private void btnAme_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 2;
            OptionClick();
        }
        private void btnCara_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 3;
            OptionClick();
        }

        private void btnMoc_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 4;
            OptionClick();
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 5;
            OptionClick();
        }

        private void btnDol_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 6;
            OptionClick();
        }

        #region CoffeeSelected event things for C# 3.0
        public event EventHandler<CoffeeSelectedEventArgs> CoffeeSelected;

        protected virtual void OnCoffeeSelected(CoffeeSelectedEventArgs e)
        {
            if (CoffeeSelected != null)
                CoffeeSelected(this, e);
        }

        private CoffeeSelectedEventArgs OnCoffeeSelected(bool coffeeOptionSelected)
        {
            CoffeeSelectedEventArgs args = new CoffeeSelectedEventArgs(coffeeOptionSelected);
            OnCoffeeSelected(args);

            return args;
        }

        private CoffeeSelectedEventArgs OnCoffeeSelectedForOut()
        {
            CoffeeSelectedEventArgs args = new CoffeeSelectedEventArgs();
            OnCoffeeSelected(args);

            return args;
        }

        public class CoffeeSelectedEventArgs : EventArgs
        {
            public bool CoffeeOptionSelected { get; set; }

            public CoffeeSelectedEventArgs()
            {
            }

            public CoffeeSelectedEventArgs(bool coffeeOptionSelected)
            {
                CoffeeOptionSelected = coffeeOptionSelected;
            }
        }

        #endregion


    }
}
