using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITravel.IServices;
using WebAPITravel.Models;

namespace WebAPITravel.Services
{
    public class TravelService : ITravelService
    {
        TravelWebAPIDbContext dbContext;
        public TravelService(TravelWebAPIDbContext db)
        {
            dbContext = db;
        }

        public Travel AddTravel(Travel travel)
        {
            dbContext.Travel.Add(travel);
            dbContext.SaveChanges();
            return travel;
        }

        public Travel Deletetravel(int id)
        {
            var pro = dbContext.Travel.Find(id);
            dbContext.Travel.Remove(pro);
            dbContext.SaveChanges();
            return pro;
        }

        public IEnumerable<Travel> GetTravel()
        {
            return dbContext.Travel.ToList();
        }

        public Travel Updatetravel(Travel travel)
        {
            dbContext.Entry(travel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return travel;
        }
    }
}
