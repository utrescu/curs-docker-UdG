using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Colors.Models;

namespace Colors.Controllers
{
    #region TodoController
    [Route("[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly ColorContext _context;
        private Random aleatori = new Random();

        public ColorsController(ColorContext context)
        {
            _context = context;
        }
        #endregion

        // GET: /Colors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Color>>> GetColors()
        {
            return await _context.Colors.ToListAsync();
        }

        // GET: /Colors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Color>> GetColor(long id)
        {
            var Color = await _context.Colors.FindAsync(id);

            if (Color == null)
            {
                return NotFound();
            }

            return Color;
        }

        // GET: /Colors/Random
        [HttpGet("Random")]
        public async Task<ActionResult<Color>> GetRandom()
        {
            var Colors = await _context.Colors.ToListAsync();
            var numColors = Colors.Count;
            if (numColors > 0)
            {
                var choosed = aleatori.Next(0, numColors);
                return Colors[choosed];
            }

            return BadRequest("No hi ha colors");
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        #region snippet_Update
        // PUT: api/Colors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(long id, Color Color)
        {
            if (id != Color.Id)
            {
                return BadRequest();
            }

            _context.Entry(Color).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColorExists(id))
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
        #endregion

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        #region snippet_Create
        // POST: api/Colors
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color Color)
        {
            if (RgbExists(Color))
            {
                return BadRequest("Color already exists");
            }
            _context.Colors.Add(Color);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetColor", new { id = Color.Id }, Color);
            return CreatedAtAction(nameof(GetColor), new { id = Color.Id }, Color);
        }


        #endregion

        #region snippet_Delete
        // DELETE: api/Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(long id)
        {
            var Color = await _context.Colors.FindAsync(id);
            if (Color == null)
            {
                return NotFound();
            }

            _context.Colors.Remove(Color);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        #endregion

        private bool ColorExists(long id)
        {
            return _context.Colors.Any(e => e.Id == id);
        }

        private bool RgbExists(Color color)
        {
            return _context.Colors.Any(c => c.Rgb == color.Rgb);
        }
    }
}