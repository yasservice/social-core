using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social_core_exended.Models;

namespace Social_core_exended.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataModelsController : ControllerBase
    {
        private readonly UserDataContext _context;

        public UserDataModelsController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/UserDataModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDataModel>>> GetUserDataModels()
        {
            return await _context.UserDataModels.ToListAsync();
        }

        // GET: api/UserDataModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDataModel>> GetUserDataModel(int id)
        {
            var userDataModel = await _context.UserDataModels.FindAsync(id);

            if (userDataModel == null)
            {
                return NotFound();
            }

            return userDataModel;
        }

        // PUT: api/UserDataModels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserDataModel(int id, UserDataModel userDataModel)
        {
            if (id != userDataModel.id)
            {
                return BadRequest();
            }

            _context.Entry(userDataModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDataModelExists(id))
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

        // POST: api/UserDataModels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserDataModel>> PostUserDataModel(UserDataModel userDataModel)
        {
            Console.WriteLine("ЕГЕ");
            _context.UserDataModels.Add(userDataModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserDataModel), new { id = userDataModel.id }, userDataModel);
        }

        // DELETE: api/UserDataModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDataModel>> DeleteUserDataModel(int id)
        {
            var userDataModel = await _context.UserDataModels.FindAsync(id);
            if (userDataModel == null)
            {
                return NotFound();
            }

            _context.UserDataModels.Remove(userDataModel);
            await _context.SaveChangesAsync();

            return userDataModel;
        }

        private bool UserDataModelExists(int id)
        {
            return _context.UserDataModels.Any(e => e.id == id);
        }
    }
}
