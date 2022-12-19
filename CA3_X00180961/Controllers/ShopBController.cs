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
    [Route("api/[controller]")]
    [ApiController]
    public class ShopBController : ControllerBase
    {
        private readonly IShopRepo _repo;

        public ShopBController(IShopRepo repo)
        {
            _repo = repo;
        }

        // GET: api/ProductFromShopBModels
        [Route("All")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopB>>> GetProductFromShopBModel()
        {
            return  _repo.GetProductModelsFromB().ToList();
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult<ShopB> PostShopB(ShopB product)
        {

            _repo.CreateProductB(product);
            return CreatedAtAction("GetProductsA", new { id = product.ProductId }, product);
        }

        [Route("Delete{id}")]
        [HttpDelete]
        public void DeleteDeleteFromShopB(int id)
        {
            _repo.DeleteFromShopA(id);

        }
        /*
         // GET: api/ProductFromShopBModels/5
         [HttpGet("{id}")]
         public async Task<ActionResult<ProductFromShopBModel>> GetProductFromShopBModel(int id)
         {
             var productFromShopBModel = await _context.ProductFromShopBModel.FindAsync(id);

             if (productFromShopBModel == null)
             {
                 return NotFound();
             }

             return productFromShopBModel;
         }

         // PUT: api/ProductFromShopBModels/5
         // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
         [HttpPut("{id}")]
         public async Task<IActionResult> PutProductFromShopBModel(int id, ProductFromShopBModel productFromShopBModel)
         {
             if (id != productFromShopBModel.ProductId)
             {
                 return BadRequest();
             }

             _context.Entry(productFromShopBModel).State = EntityState.Modified;

             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!ProductFromShopBModelExists(id))
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

         // POST: api/ProductFromShopBModels
         // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
         [HttpPost]
         public async Task<ActionResult<ProductFromShopBModel>> PostProductFromShopBModel(ProductFromShopBModel productFromShopBModel)
         {
             _context.ProductFromShopBModel.Add(productFromShopBModel);
             await _context.SaveChangesAsync();

             return CreatedAtAction("GetProductFromShopBModel", new { id = productFromShopBModel.ProductId }, productFromShopBModel);
         }

         // DELETE: api/ProductFromShopBModels/5
         [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteProductFromShopBModel(int id)
         {
             var productFromShopBModel = await _context.ProductFromShopBModel.FindAsync(id);
             if (productFromShopBModel == null)
             {
                 return NotFound();
             }

             _context.ProductFromShopBModel.Remove(productFromShopBModel);
             await _context.SaveChangesAsync();

             return NoContent();
         }

         private bool ProductFromShopBModelExists(int id)
         {
             return _context.ProductFromShopBModel.Any(e => e.ProductId == id);
         }
        */
    }
}
