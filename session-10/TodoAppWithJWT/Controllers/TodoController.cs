using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Data;
using TodoAppWithJWT.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace TodoAppWithJWT.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {

        private readonly ApiDbContext _context;

        // DI
        public TodoController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet] 
        public async Task<IActionResult> GetItems()
        {
            var item =  await _context.Items.ToListAsync();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.Id}, data); 
            }

            return new JsonResult("Something went wrong") {StatusCode= 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(
                x => x.Id == id
            );

            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item) 
        {
            //if (id != item.Id) return BadRequest();

            var existItem = await _context.Items.FirstOrDefaultAsync(
                x => x.Id == id
            );

            if(existItem == null) return NotFound();

            existItem.Title = item.Title;
            existItem.Description = item.Description;
            existItem.Done = item.Done;

            // synch existItem to database (not detached state)
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(
                x => x.Id == id
            );

            if (existItem == null) return NotFound();

            _context.Items.Remove(existItem);

            await _context.SaveChangesAsync();

            return Ok(existItem);

        }

        

    }
}