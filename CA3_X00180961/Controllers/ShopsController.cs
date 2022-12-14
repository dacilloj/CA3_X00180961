using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using CA3_X00180961.ShopRepository;
using ShopRepository.Repository;

namespace CA3_X00180961.Controllers
{
    [Route("api/Shops")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IShopRepo _repo;

        public ShopsController(IShopRepo repo)
        {
            _repo = repo;
        }

        // GET: api/ShopModels
        [Route("All")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopModel>>> GetShopModel()
        {
            return _repo.GetShopModels().ToList();
        }

        [HttpPost]
        public  ActionResult<ShopModel> PostShopModel(ShopModel shopModel)
        {
             _repo.CreateShop(shopModel);

            return CreatedAtAction("GetShopModel", new { id = shopModel.ShopId }, shopModel);
        }

        // DELETE: api/ShopModels/5
        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<IActionResult> DeleteShopModel(int id)
        {
 
            _repo.DeleteFromShop(id);

            return NoContent();
        }
        /*
        // GET: api/ShopModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopModel>> GetShopModel(int id)
        {
            var shopModel = await _context.ShopModel.FindAsync(id);

            if (shopModel == null)
            {
                return NotFound();
            }

            return shopModel;
        }

        // PUT: api/ShopModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopModel(int id, ShopModel shopModel)
        {
            if (id != shopModel.ShopId)
            {
                return BadRequest();
            }

            _context.Entry(shopModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopModelExists(id))
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

        // POST: api/ShopModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShopModel>> PostShopModel(ShopModel shopModel)
        {
            _context.ShopModel.Add(shopModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopModel", new { id = shopModel.ShopId }, shopModel);
        }

        

        private bool ShopModelExists(int id)
        {
            return _context.ShopModel.Any(e => e.ShopId == id);
        }
        */
    }
}
