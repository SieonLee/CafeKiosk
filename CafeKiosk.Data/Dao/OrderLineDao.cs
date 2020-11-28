using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class OrderLineDao : SingleKeyDao<OrderLine, int>
    {
        #region override
        internal OrderLineDao() { }

        protected override Expression<Func<OrderLine, int>> KeySelector => x => x.OrderLineID;

        protected override Expression<Func<OrderLine, bool>> IsKey(int key)
        {
            return x => x.OrderLineID == key;
        }
        #endregion
        
        public List<OrderLine> GetByMenuId(int MenuId)
        {
            using (var context = new CafeKioskEntities())
            {
                var query = from x in context.OrderLines
                            where x.MenuID == MenuId
                            select x;

                return query.ToList();
            }
        }

        public List<OrderLine> GetByOrderId(int OrderId)
        {
            using (var context = new CafeKioskEntities())
            {
                var query = from x in context.OrderLines
                            where x.OrderID == OrderId
                            select x;

                return query.ToList();
            }
        }
    }
}
