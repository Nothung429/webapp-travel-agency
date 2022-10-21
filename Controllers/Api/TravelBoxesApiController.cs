using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapp_travel_agency.Data;

namespace webapp_travel_agency.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TravelBoxesApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TravelBoxesApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TravelBoxesApi
        [HttpGet]
        public IActionResult GetTravelBoxList(string? title)
        {
            IQueryable<TravelBox> TravelBoxDB;

            if (title != null)
            {
                TravelBoxDB = _context.TravelBox.Where(travelbox => travelbox.Title.ToLower().Contains(title.ToLower()));
            }
            else
            {
                TravelBoxDB = _context.TravelBox;
            }

            return Ok(TravelBoxDB.ToList<TravelBox>());
        }

        // GET: api/TravelBoxesApi/5
        [HttpGet("{id}")]
        public IActionResult GetTravelBoxId(int id)
        {
            TravelBox travel = _context.TravelBox.Where(p => p.Id == id).FirstOrDefault();

            return Ok(travel);
        }
    }
}
