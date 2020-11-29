using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class Dao
    {
        public static OrderLineDao OrderLine { get; } = new OrderLineDao();
        public static OrderLineOptionDao OrderLineOption { get; } = new OrderLineOptionDao();
        public static OrderDao Order { get;  } = new OrderDao();
        public static MenuDao Menu { get; } = new MenuDao();
        public static OptionDao Option { get; } = new OptionDao();
    }
    
}

