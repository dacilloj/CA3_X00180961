using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using CA3_X00180961.ShopRepository;

namespace CA3_X00180961.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemModelsController : ControllerBase
    {
        private readonly CA3_X00180961Context _context;

        public ItemModelsController(CA3_X00180961Context context)
        {
            _context = context;
        }

        // GET: api/ItemModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemModel>>> GetItemModel()
        {
            return await _context.ItemModel.ToListAsync();
        }

        // GET: api/ItemModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetItemModel(int id)
        {
            var itemModel = await _context.ItemModel.FindAsync(id);

            if (itemModel == null)
            {
                return NotFound();
            }

            return itemModel;
        }

        // PUT: api/ItemModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemModel(int id, ItemModel itemModel)
        {
            if (id != itemModel.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(itemModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemModelExists(id))
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

        // POST: api/ItemModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemModel>> PostItemModel(ItemModel itemModel)
        {
            _context.ItemModel.Add(itemModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemModel", new { id = itemModel.ItemId }, itemModel);
        }

        // DELETE: api/ItemModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemModel(int id)
        {
            var itemModel = await _context.ItemModel.FindAsync(id);
            if (itemModel == null)
            {
                return NotFound();
            }

            _context.ItemModel.Remove(itemModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemModelExists(int id)
        {
            return _context.ItemModel.Any(e => e.ItemId == id);
        }
    }
}
