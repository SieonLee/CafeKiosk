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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        string message1 = "포장을 선택하셨습니다";
        string message2 = "매장이용을 선택하셨습니다";
        string title = "포장여부";


        private void bntTakeout_Click(object sender, EventArgs e)
        {
            OnTakeOutSelected(true);
        }

        private void btnNoTakeOut_Click(object sender, EventArgs e)
        {
            OnTakeOutSelected(false);
        }

        #region TakeOutSelected event things for C# 3.0
        public event EventHandler<TakeOutSelectedEventArgs> TakeOutSelected;

        protected virtual void OnTakeOutSelected(TakeOutSelectedEventArgs e)
        {
            if (TakeOutSelected != null)
                TakeOutSelected(this, e);
        }

        private TakeOutSelectedEventArgs OnTakeOutSelected(bool takenOut)
        {
            TakeOutSelectedEventArgs args = new TakeOutSelectedEventArgs(takenOut);
            OnTakeOutSelected(args);

            return args;
        }

        private TakeOutSelectedEventArgs OnTakeOutSelectedForOut()
        {
            TakeOutSelectedEventArgs args = new TakeOutSelectedEventArgs();
            OnTakeOutSelected(args);

            return args;
        }

        public class TakeOutSelectedEventArgs : EventArgs
        {
            public bool TakenOut { get; set; }

            public TakeOutSelectedEventArgs()
            {
            }

            public TakeOutSelectedEventArgs(bool takenOut)
            {
                TakenOut = takenOut;
            }
        }
        #endregion
    }
}
