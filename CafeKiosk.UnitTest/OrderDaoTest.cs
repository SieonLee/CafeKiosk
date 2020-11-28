using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeKiosk.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace CafeKiosk.UnitTest
{
    [TestClass]
    public class OrderDaoTest
    {
        
        [TestMethod]
        public void GetCountTest()
        {
            int count = Dao.Order.GetCount();
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void InsertTest()
        {
            int oldCount = Dao.Order.GetCount();
            
            Order entity = new Order();
            entity.OrderID = oldCount + 1;
            entity.TakeOut = false;
            entity.OrderedAt = DateTime.Now;
            entity.Total = 1000;
            Dao.Order.Insert(entity);

            int newCount = Dao.Order.GetCount();
            Assert.AreEqual(oldCount+1, newCount);
        }
        [TestMethod]
        public void DeleteTest()
        {
            int oldCount = Dao.Order.GetCount(); //5

            Order entity = new Order();
            entity.OrderID = oldCount + 1; //6
            entity.TakeOut = false;
            entity.OrderedAt = DateTime.Now;
            entity.Total = 1000;
            Dao.Order.Insert(entity);

            
            int orderId = Dao.Order.GetMaxKey(); //6

            Dao.Order.DeleteByPK(orderId);//5


            int newCount = Dao.Order.GetCount();

            Assert.AreEqual(oldCount, newCount);
        }
    }
}
