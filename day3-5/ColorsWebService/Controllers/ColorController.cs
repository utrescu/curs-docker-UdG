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

    }
}