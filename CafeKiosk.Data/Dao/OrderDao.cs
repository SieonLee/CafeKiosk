﻿using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeKiosk.Data
{
    public class OrderDao : SingleKeyDao<Order, int>
    {
        protected override Expression<Func<Order, int>> KeySelector => x => x.OrderID;

        protected override Expression<Func<Order, bool>> IsKey(int key)
        {
            return x => x.OrderID == key;
        }
    }
}
