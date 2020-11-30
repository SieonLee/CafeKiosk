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
    public partial class UCJuice : UserControl
    {
        public UCJuice()
        {
            InitializeComponent();
        }
   
        public UCJuice(int orderId) : this()
        {
            _OrderID = orderId;
        }
        int _OrderID; //orderid를 넘겨받음
        OrderLine _orderLine = new OrderLine();
        int orderLineId = 0;

        public void OptionClick() //함수 만들어야함
        {
            _orderLine.OrderID = _OrderID;
            _orderLine.OrderLineID = orderLineId + 1;
            _orderLine.Quantity = 1;
            Dao.OrderLine.Insert(_orderLine);
            OnJuiceSelected(true);//주스를 눌렀을때 옵션 패널 호출
        }
        private void btnJamongAde_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 7;
            OptionClick();

        }

        private void btnLemonAde_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 8;
            OptionClick();
        }

        private void btnLemonTea_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 9;
            OptionClick();
        }

        private void btnMango_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 10;
            OptionClick();
        }

        private void btnFlane_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 11;
            OptionClick();
        }

        private void btnBlueBerry_Click(object sender, EventArgs e)
        {
            _orderLine.MenuID = 12;
            OptionClick();
        }

        #region JuiceSelected event things for C# 3.0
        public event EventHandler<JuiceSelectedEventArgs> JuiceSelected;

        protected virtual void OnJuiceSelected(JuiceSelectedEventArgs e)
        {
            if (JuiceSelected != null)
                JuiceSelected(this, e);
        }

        private JuiceSelectedEventArgs OnJuiceSelected(bool juiceOptionSelected)
        {
            JuiceSelectedEventArgs args = new JuiceSelectedEventArgs(juiceOptionSelected);
            OnJuiceSelected(args);

            return args;
        }

        private JuiceSelectedEventArgs OnJuiceSelectedForOut()
        {
            JuiceSelectedEventArgs args = new JuiceSelectedEventArgs();
            OnJuiceSelected(args);

            return args;
        }

        public class JuiceSelectedEventArgs : EventArgs
        {
            public bool JuiceOptionSelected { get; set; }

            public JuiceSelectedEventArgs()
            {
            }

            public JuiceSelectedEventArgs(bool juiceOptionSelected)
            {
                JuiceOptionSelected = juiceOptionSelected;
            }
        }
        #endregion

    }
}
