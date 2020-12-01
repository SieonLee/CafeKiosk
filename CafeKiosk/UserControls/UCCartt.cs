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

namespace CafeKiosk
{
    public partial class UCCartt : UserControl
    {
        public UCCartt()
        {
            InitializeComponent();
        }
        public int OrderId { get; set; }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            OnMovePrevSelected(true);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var gridViewInformation = Dao.OrderLineOption.Search(Dao.Order.GetMaxKey());

            List<OrderLineOption> wantedList = new List<OrderLineOption>();

            foreach (var item in gridViewInformation)
            {
                OrderLineOption information = new OrderLineOption();
                information.OptionName = item.Option.Name;
                information.MenuName = item.OrderLine.Menu.Name;
                information.MenuPrice = item.OrderLine.Menu.Price;

                wantedList.Add(information);
            }
            bdsOrderLineOption.DataSource = wantedList;
        }


        #region MovePrevSelected event things for C# 3.0
        public event EventHandler<MovePrevSelectedEventArgs> MovePrevSelected;

        protected virtual void OnMovePrevSelected(MovePrevSelectedEventArgs e)
        {
            if (MovePrevSelected != null)
                MovePrevSelected(this, e);
        }

        private MovePrevSelectedEventArgs OnMovePrevSelected(bool movePrev)
        {
            MovePrevSelectedEventArgs args = new MovePrevSelectedEventArgs(movePrev);
            OnMovePrevSelected(args);

            return args;
        }

        private MovePrevSelectedEventArgs OnMovePrevSelectedForOut()
        {
            MovePrevSelectedEventArgs args = new MovePrevSelectedEventArgs();
            OnMovePrevSelected(args);

            return args;
        }

        public class MovePrevSelectedEventArgs : EventArgs
        {
            public bool MovePrev { get; set; }

            public MovePrevSelectedEventArgs()
            {
            }

            public MovePrevSelectedEventArgs(bool movePrev)
            {
                MovePrev = movePrev;
            }
        }

        #endregion

        private void UCCartt_Load(object sender, EventArgs e)
        {
            bdsOrderLineOption.DataSource = CafeKiosk.Data.Dao.OrderLineOption.Search(OrderId);
        }


    }
}
