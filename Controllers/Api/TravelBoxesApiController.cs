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















        // PUT: api/TravelBoxesApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravelBox(int id, TravelBox travelBox)
        {
            if (id != travelBox.Id)
            {
                return BadRequest();
            }

            _context.Entry(travelBox).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelBoxExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TravelBoxesApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TravelBox>> PostTravelBox(TravelBox travelBox)
        {
            _context.TravelBox.Add(travelBox);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravelBox", new { id = travelBox.Id }, travelBox);
        }

        // DELETE: api/TravelBoxesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravelBox(int id)
        {
            var travelBox = await _context.TravelBox.FindAsync(id);
            if (travelBox == null)
            {
                return NotFound();
            }

            _context.TravelBox.Remove(travelBox);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravelBoxExists(int id)
        {
            return _context.TravelBox.Any(e => e.Id == id);
        }
    }
}
