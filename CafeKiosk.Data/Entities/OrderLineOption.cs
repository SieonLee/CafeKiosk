using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public partial class OrderLineOption
    {
        public string OptionName { get; set; }
        
        public string MenuName { get; set; }
        
        public int MenuPrice { get; set; }
    }
}
