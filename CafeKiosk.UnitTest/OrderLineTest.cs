using CafeKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        public void GetAllTest()
        {
            List<OrderLine> list = Dao.OrderLine.GetAll();

            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void GetByPKTest()
        {
            OrderLine orderline = Dao.OrderLine.GetByPK(1);

            Assert.AreEqual(1, orderline.OrderLineID);
        }
        [TestMethod]
        public void WrongGetByPKTest()
        {
            OrderLine orderline = Dao.OrderLine.GetByPK(1000);

            Assert.IsNull(orderline);
        }

        [TestMethod]
        public void InsertTest()
        {
            int oldCount = Dao.OrderLine.GetCount();

            OrderLine entity = new OrderLine();
            entity.OrderID = Dao.Order.GetMaxKey();
            entity.MenuID = Dao.Menu.GetByPK(1).MenuID;
            entity.Quantity = 3;

            Dao.OrderLine.Insert(entity);

            int newCount = Dao.OrderLine.GetCount();

            Assert.AreEqual(oldCount + 1, newCount);
        }

        [TestMethod()]
        public void DeleteByPKTest()
        {
            OrderLine entity = new OrderLine();
            entity.OrderID = Dao.Order.GetMaxKey();
            entity.MenuID = Dao.Menu.GetByPK(1).MenuID;
            entity.Quantity = 3;

            Dao.OrderLine.Insert(entity);

            int orderLineId = Dao.OrderLine.GetMaxKey();
            int oldCount = Dao.OrderLine.GetCount();
            

            Dao.OrderLine.DeleteByPK(orderLineId);

            int newCount = Dao.OrderLine.GetCount();

            Assert.AreEqual(oldCount - 1, newCount);
        }

        [TestMethod]
        public void GetByMenuIdTest()
        {
            var orderLines = Dao.OrderLine.GetByMenuId(1);

            Assert.IsTrue(orderLines.Count > 0);
            Assert.IsTrue(orderLines.TrueForAll(x => x.MenuID == 1));
        }

        [TestMethod]
        public void GetByOrderId()
        {
            var orderLines = Dao.OrderLine.GetByOrderId(1);

            Assert.IsTrue(orderLines.Count > 0);
            Assert.IsTrue(orderLines.TrueForAll(x => x.OrderID == 1));
        }   
    }
}
