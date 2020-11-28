using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data.Entities
{
    public partial class OrderLine
    {
        public string MenuName { get; set; }

        public int MenuPrice { get; set; }
    }
}
