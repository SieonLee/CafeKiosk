using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Data
{
    public class Dao
    {
       
        //public static HomeDao Home { get; } = new HomeDao();
        public static CoffeeDao Coffee { get; } = new CoffeeDao();
        public static DessertDao Dessert { get; } = new DessertDao();
        public static JuiceDao Juice { get; } = new JuiceDao();
       // public static CartDao Cart { get; } = new CartDao();
    }
    
}

