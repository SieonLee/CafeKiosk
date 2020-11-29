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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }


        private void bntTakeout_Click(object sender, EventArgs e)
        {

            OnTakeOutSelected(true);
        }

        private void btnNoTakeOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("지금은 사회적 거리두기 2단계로 매장을 이용하실수 없습니다", "ms", MessageBoxButtons.OK);
            //OnTakeOutSelected(false);

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
