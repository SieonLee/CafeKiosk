using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class OptionDao : SingleKeyDao<Option, int>
    {
        #region override
        internal OptionDao() { }

        protected override Expression<Func<Option, bool>> IsKey(int key)
        {
            return x => x.OptionID == key;
        }
        protected override Expression<Func<Option, int>> KeySelector =>
            x => x.OptionID;
        #endregion

    }
}
