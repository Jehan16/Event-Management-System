using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EAttendeeController : ControllerBase
    {
        private readonly EventDBContext _context;

        public EAttendeeController(EventDBContext context)
        {
            _context = context;
        }

        // GET: api/EAttendee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EAttendee>>> GetEAttendees()
        {
            return await _context.EAttendees.ToListAsync();
        }

        // GET: api/EAttendee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EAttendee>> GetEAttendee(int id)
        {
            var eAttendee = await _context.EAttendees.FindAsync(id);

            if (eAttendee == null)
            {
                return NotFound();
            }

            return eAttendee;
        }

        // PUT: api/EAttendee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEAttendee(int id, EAttendee eAttendee)
        {
            eAttendee.Id = id;

            _context.Entry(eAttendee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EAttendeeExists(id))
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

        // POST: api/EAttendee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EAttendee>> PostEAttendee(EAttendee eAttendee)
        {
            _context.EAttendees.Add(eAttendee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEAttendee", new { id = eAttendee.Id }, eAttendee);
        }

        // DELETE: api/EAttendee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEAttendee(int id)
        {
            var eAttendee = await _context.EAttendees.FindAsync(id);
            if (eAttendee == null)
            {
                return NotFound();
            }

            _context.EAttendees.Remove(eAttendee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EAttendeeExists(int id)
        {
            return _context.EAttendees.Any(e => e.Id == id);
        }
    }
}
