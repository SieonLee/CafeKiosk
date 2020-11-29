using CafeKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CafeKiosk.UnitTest
{
    [TestClass]
    public class OrderLineOptionTest
    {
        [TestMethod]
        public void GetCountPKTest()
        {
            int count = Dao.OrderLineOption.GetCount();

            Assert.IsTrue(count > 0);
        }
        
        [TestMethod]
        public void GetAllTest()
        {
            List<OrderLineOption> list = Dao.OrderLineOption.GetAll();

            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod()]
        public void GetByPKTest()
        {
            OrderLineOption entity = Dao.OrderLineOption.GetByPK(1, 4); // OrderLineID, OptionID

            Assert.AreEqual(1, entity.OrderLineID);
            Assert.AreEqual(4, entity.OptionID);
        }

        [TestMethod()]
        public void WrongGetByPKTest()
        {
            OrderLineOption entity = Dao.OrderLineOption.GetByPK(1, 10000); // OrderLineID, OptionID

            Assert.IsNull(entity);
        }
        //[TestMethod()]
        //public void InsertTest()
        //{
        //    int oldCount = Dao.OrderLineOption.GetCount();
        //    Dao.OrderLineOption.Insert(); // OrderLineID, OptionID
        //    int newCount = Dao.OrderLineOption.GetCount();
        //    Assert.AreEqual(oldCount + 1, newCount);
        //}

        [TestMethod]
        public void SearchTest()
        {
            //첫번째 손님이 구매한 정보 중 MenuName과 MenuPrice와 OptionName을 알고 싶음
            var gridViewInformation = Dao.OrderLineOption.Search(Dao.Order.GetByPK(1).OrderID);

            foreach(var item in gridViewInformation)
            {
                Assert.IsNotNull(item.Option.Name);
                Assert.IsNotNull(item.OrderLine.Menu.Name);
                Assert.IsNotNull(item.OrderLine.Menu.Price);
            }


        }

        //[TestMethod]
        //public void DeleteByPKTest()
        //{
        //    Dao.OrderLineOption.DeleteByPK(Dao.OrderLine.GetMaxKey(),
        //        Dao.Option.GetMaxKey());

        //    PlaylistTrack entity = new PlaylistTrack();
        //    entity.PlaylistId = Dao.Playlist.GetMaxKey();
        //    entity.TrackId = Dao.Track.GetMaxKey();
        //    Dao.PlaylistTrack.Insert(entity);

        //    int oldCount = Dao.PlaylistTrack.GetCount();

        //    Dao.PlaylistTrack.DeleteByPK(Dao.Playlist.GetMaxKey(),
        //        Dao.Track.GetMaxKey());

        //    int newCount = Dao.PlaylistTrack.GetCount();

        //    Assert.AreEqual(oldCount - 1, newCount);
        //}
    }
}
