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
    public partial class UCCoffeeOption : UserControl
    {
        int quantity = 1;

        public UCCoffeeOption()
        {
            InitializeComponent();
            lblQuantity.Text = quantity.ToString();
           

        }
        
        public UCCoffeeOption(int orderLineId) : this()
        {
            _orderLineId = orderLineId;
        }
        int _orderLineId;


        //public UCCoffeeOption(int orderLineId) : this()
        //{
        //    orderLineId = Dao.OrderLine.GetCount();
        //}


        // OrderLine _orderLine = new OrderLine();
        OrderLineOption _orderLineOption = new OrderLineOption();

        internal void btnReturn_Click(object sender, EventArgs e) //이전화면
        {
            OnReturnCoffeeMenu(true);

        }
 
       // int orderLineid = Dao.OrderLineOption.GetCount();
        List<int> optionNum = new List<int>();
       // int orderLineId = Dao.OrderLine.GetCount();
        //장바구니로
        public void Cart()
        {
            //  _orderLine.Quantity = int.Parse(lblQuantity.Text);  //db안에 orderLineOption quantity (수량)넣어주기

            foreach (int number in optionNum)
            {
                _orderLineOption.OrderLineID = _orderLineId;
                _orderLineOption.OptionID = number;
                Dao.OrderLineOption.Insert(_orderLineOption);
            }
            //옵션 여러개 들어가도록
            //   foreach(int number in optionNum)
            //    {
            //     _orderLineOption.OptionID = number;
            //       Dao.OrderLineOption.Insert(_orderLineOption);
            //    }
            
        }


        internal void btnToCart_Click(object sender, EventArgs e) //장바구니
        {
            Cart();
            
            OnReturnCoffeeMenu(true);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity == 0)
            {
                quantity = 1;
            }
            quantity -= 1;
            lblQuantity.Text = quantity.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            quantity += 1;
            lblQuantity.Text = quantity.ToString();
        }

        //옵션 : 사이즈
        private void btnTall_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTall.Checked == true)
            {
                optionNum.Add(2);

            }
        }

        private void btnGrande_CheckedChanged(object sender, EventArgs e)
        {

        }

        //옵션 아이스 핫

        private void btnIce_CheckedChanged(object sender, EventArgs e)
        {
            if (btnIce.Checked == true)
            {
                optionNum.Add(4);
            }
        }

        private void btnHot_CheckedChanged(object sender, EventArgs e)
        {
            if (btnHot.Checked == true)
            {
                optionNum.Add(5);
            }
        }

        //휘핑, 시럽
        bool isCheckedW = false;
        private void btnWhip_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedW = btnWhip.Checked;
            if (btnWhip.Checked == true)
            {
                optionNum.Add(6);
            }
        }
        private void btnWhip_Click(object sender, EventArgs e)
        {
            if (btnWhip.Checked && !isCheckedW)
            {
                btnWhip.Checked = false;
            }
            else
            {
                btnWhip.Checked = true;
                isCheckedW = false;
            }
        }


        bool isCheckedS = false;
        private void btnSyrup_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedS = btnSyrup.Checked;
            if (btnSyrup.Checked == true)
            {
                optionNum.Add(7);
            }
        }
        private void btnSyrup_Click(object sender, EventArgs e)
        {
            if (btnSyrup.Checked && !isCheckedS)
            {
                btnSyrup.Checked = false;
            }
            else
            {
                btnSyrup.Checked = true;
                isCheckedS = false;
            }
        }


        #region ReturnCoffeeMenu event things for C# 3.0
        public event EventHandler<ReturnCoffeeMenuEventArgs> ReturnCoffeeMenu;

        protected virtual void OnReturnCoffeeMenu(ReturnCoffeeMenuEventArgs e)
        {
            if (ReturnCoffeeMenu != null)
                ReturnCoffeeMenu(this, e);
        }

        private ReturnCoffeeMenuEventArgs OnReturnCoffeeMenu(bool returnCoffee)
        {
            ReturnCoffeeMenuEventArgs args = new ReturnCoffeeMenuEventArgs(returnCoffee);
            OnReturnCoffeeMenu(args);

            return args;
        }

        private ReturnCoffeeMenuEventArgs OnReturnCoffeeMenuForOut()
        {
            ReturnCoffeeMenuEventArgs args = new ReturnCoffeeMenuEventArgs();
            OnReturnCoffeeMenu(args);

            return args;
        }

        public class ReturnCoffeeMenuEventArgs : EventArgs
        {
            public bool ReturnCoffee { get; set; }

            public ReturnCoffeeMenuEventArgs()
            {
            }

            public ReturnCoffeeMenuEventArgs(bool returnCoffee)
            {
                ReturnCoffee = returnCoffee;
            }
        }




        #endregion
    }
}