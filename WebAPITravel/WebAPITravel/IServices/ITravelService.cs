using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITravel.Models;

namespace WebAPITravel.IServices
{
    public interface ITravelService
    {
        IEnumerable<Travel> GetTravel();

        Travel AddTravel(Travel travel);

        Travel Updatetravel(Travel travel);

        Travel Deletetravel(int id);
    }
}
