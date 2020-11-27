using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class Dao
    {
       

        public static CoffeeDao Coffee { get; } = new CoffeeDao();
        public static DessertDao Dessert { get; } = new DessertDao();
        public static JuiceDao Juice { get; } = new JuiceDao();
        public static OrderLineOptionDao OrderLineOption { get; } = new OrderLineOptionDao();

        public static OrderDao Order { get;  } = new OrderDao();

    }
    
}

