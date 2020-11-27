using CafeKiosk.Data;
using EFLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EFDemo.UnitTest
{
    [TestClass]
    public class TestInitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            DbContextCreator.Context = () => new CafeKioskEntities();
        }
    }
}
