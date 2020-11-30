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
    public partial class UCDessert : UserControl
    {
        public UCDessert()
        {
            InitializeComponent();
        }
        public UCDessert(int orderId) : this()
        {
            _OrderID = orderId;
        }
        int _OrderID;  //orderId넘겨받음

        OrderLine _orderLine = new OrderLine();
        int orderLineId = 0;
        public void OptionClick()
        {
            _orderLine.OrderID = _OrderID;
            _orderLine.OrderLineID = orderLineId + 1;
            _orderLine.Quantity = 1;
            Dao.OrderLine.Insert(_orderLine);
            OnDessertSelected(true); //디저트 눌렀을때 옵션패널 호출
        }

        private void btnChoco_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 13;
            OptionClick();
        }
        private void btnTiramisu_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 14;
            OptionClick();
        }

        private void btnHoney_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 15;
            OptionClick();
        }

        private void btnMacaron_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 16;
            OptionClick();
        }

        private void btnWaffle_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 17;
            OptionClick();
        }

        private void btnCroffle_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 18;
            OptionClick();
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
