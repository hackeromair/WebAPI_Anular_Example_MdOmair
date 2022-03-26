using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPITravel.IServices;
using WebAPITravel.Models;

namespace WebAPITravel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : Controller
    {
        private readonly ITravelService travelService;
        public TravelController(ITravelService travel)
        {
            travelService = travel;
        }
        [HttpGet]
        public IEnumerable<Travel> GetTravel()
        {
            return travelService.GetTravel();
        }
        [HttpPost]
        public Travel AddTravel(Travel tra)
        {
            return travelService.AddTravel(tra);
        }
        [HttpPut]
        public Travel EditTravel(Travel tra)
        {
            return travelService.Updatetravel(tra);
        }
        [HttpDelete]
        public Travel Deletetravel(int id)
        {
            return travelService.Deletetravel(id);
        }
    }
}
