using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{


    public class JuiceDao : SingleKeyDao<Menu, int>
    {


        internal JuiceDao() { }

        protected override Expression<Func<Menu, bool>> IsKey(int key)
        {
            return x => x.MenuID == key;
        }


        protected override Expression<Func<Menu, int>> KeySelector =>
            x => x.MenuID;



    }
}