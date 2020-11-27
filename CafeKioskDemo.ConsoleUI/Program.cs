using CafeKiosk.Data;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeKioskDemo.ConsoleUI
{
    class Program
    {
        static DbContext CreateDbContext()
        {
            return new CafeKioskEntities();
        }

        static void Main(string[] args)
        {
            //DbContextCreator.Context = () => new ChinookEntities();
            DbContextCreator.Context = CreateDbContext;

            //var albums = Dao.Coffee.GetByArtistName("pink");
        }
    }
}
