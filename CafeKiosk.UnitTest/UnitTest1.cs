using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeKiosk.Data;
using System.Collections.Generic;
using System.Linq;
using EFLibrary;
using EFDemo.Data;

namespace EFDemo.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod()]
        public void TestMethod1()
        {
            int count = Dao.Coffee.GetCount();
            Assert.IsTrue(count > 0);
        }
    }
}
