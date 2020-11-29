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
            return x => x.OrderLineID == key1 && x.OptionID == key2;
        }

        public List<OrderLineOption>Search(int orderId)
        {
            using (CafeKioskEntities context = (CafeKioskEntities)DbContextCreator.Context())
            {
                List<int> orderLineIds = context
                                                    .OrderLines
                                                    .Where(x => x.OrderID == orderId)
                                                    .Select(x => x.OrderLineID)
                                                    .ToList();

                var query = from x in context.OrderLineOptions
                            where orderLineIds.Contains(x.OrderLineID)
                            select new
                            {
                                OrderLineOption = x,
                                OptionName = x.Option.Name,
                                MenuName = x.OrderLine.Menu.Name,
                                MenuPrice = x.OrderLine.Menu.Price,
                            };

                var list = query.ToList();

                foreach(var item in list)
                {
                    item.OrderLineOption.Option.Name = item.OptionName;
                    item.OrderLineOption.OrderLine.Menu.Name = item.MenuName;
                    item.OrderLineOption.OrderLine.Menu.Price = item.MenuPrice;
                }

                return list.ConvertAll(x => x.OrderLineOption).ToList();
            }
        }
    }
}
