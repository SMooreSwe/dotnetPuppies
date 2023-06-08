using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace puppiesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuppiesController : ControllerBase
    {
        private readonly MvcPuppyContext _context;

        public PuppiesController(MvcPuppyContext context)
        {
            _context = context;
        }

        // GET: api/Puppies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puppy>>> GetPuppies()
        {
          if (_context.Puppy == null)
          {
              return NotFound();
          }
            return await _context.Puppy.ToListAsync();
        }

        // GET: api/Puppies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Puppy>> GetPuppy(string id)
        {
          if (_context.Puppy == null)
          {
              return NotFound();
          }
            var puppy = await _context.Puppy.FindAsync(id);

            if (puppy == null)
            {
                return NotFound();
            }

            return puppy;
        }

        // PUT: api/Puppies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuppy(string id, Puppy puppy)
        {
             if (!PuppyExists(id))
                {
                    return NotFound();
                }

            _context.Entry(puppy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(409);
            }

            return NoContent();
        }

        // POST: api/Puppies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Puppy>> PostPuppy(AddPuppyDTO puppy)
        {
          if (_context.Puppy == null)
          {
              return Problem("Entity set 'MvcPuppyContext.Puppy'  is null.");
          }
            var result = new Puppy
            {
                Id = puppy.Id,
                Name = puppy.Name,
                Breed = puppy.Breed,
                BirthDate = puppy.BirthDate,
            };
            var newPuppy = _context.Puppy.Add(result);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPuppy), new { id = result.Id }, result);
        }

        // DELETE: api/Puppies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePuppy(string id)
        {
            if (_context.Puppy == null)
            {
                return NotFound();
            }
            var puppy = await _context.Puppy.FindAsync(id);
            if (puppy == null)
            {
                return NotFound();
            }

            _context.Puppy.Remove(puppy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PuppyExists(string id)
        {
            return (_context.Puppy?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
