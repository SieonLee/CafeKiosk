using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class MenuDao : SingleKeyDao<Menu, int>
    {
        #region override
        internal MenuDao() { }

        protected override Expression<Func<Menu, bool>> IsKey(int key)
        {
            return x => x.MenuID == key;
        }
        protected override Expression<Func<Menu, int>> KeySelector =>
            x => x.MenuID;
        #endregion

    }
}
