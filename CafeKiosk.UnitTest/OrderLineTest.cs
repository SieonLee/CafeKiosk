using CafeKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CafeKiosk.UnitTest
{
    [TestClass]
    public class OrderLineTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            int count = Dao.OrderLine.GetCount();

            Assert.IsTrue(count > 0);
        }
        [TestMethod]
        public void InsertTest()
        {
            int oldCount = Dao.OrderLine.GetCount();

            OrderLine entity = new OrderLine();
            entity.OrderID = Dao.Order.GetMaxKey();
            entity.MenuID = Dao.Menu.GetByPK(1).MenuID;

            Dao.OrderLine.Insert(entity);

            int newCount = Dao.OrderLine.GetCount();

            Assert.AreEqual(oldCount + 1, newCount);
        }
        
        [TestMethod]
        public void GetByMenuIdTest()
        {

        }

        [TestMethod]
        public void GetByOrderId()
        {

        }
    }
}
