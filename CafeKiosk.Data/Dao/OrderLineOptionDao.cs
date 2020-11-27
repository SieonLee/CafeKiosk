using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class OrderLineOptionDao : DualKeyDao<OrderLineOption, int, int>
    {
        protected override Expression<Func<OrderLineOption, bool>> IsKey(int key1, int key2)
        {
            return x => x.OrderMenuLineID == key1 && x.OptionID == key2;
        }

        public List<OrderLineOption> Search(int orderId)
        {
            using (CafeKioskEntities contexxt = (CafeKioskEntities)DbContextCreator.Context())
            {
                List<int> orderLineIds = contexxt
                                            .OrderLines
                                            .Where(x => x.OrderID == orderId)
                                            .Select(x => x.OrderMenuLineID)
                                            .ToList();

                var query = from x in contexxt.OrderLineOptions
                            where orderLineIds.Contains(x.OrderMenuLineID)
                            select new
                            {
                                OrderLineOption = x,
                                OptionName = x.Option.Name,
                                MenuName = x.OrderLine.Menu.MenuName,
                                MenuPrice = x.OrderLine.Menu.MenuPrice,
                            };

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.OrderLineOption.OptionName = item.OptionName;
                    item.OrderLineOption.MenuName = item.MenuName;
                    item.OrderLineOption.MenuPrice = item.MenuPrice;
                }

                return list.ConvertAll(x => x.OrderLineOption).ToList();
            }
        }
    }
}
