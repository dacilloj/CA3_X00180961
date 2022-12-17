﻿using System;
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
    public class ProductFromShopAModelController : ControllerBase
    {
        private readonly IShopRepo _repo;

        public ProductFromShopAModelController(IShopRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public IEnumerable<ProductFromShopAModel> GetProductsA()
        {
            return _repo.GetProductModelsFromA();
        }

        /*
        // GET: api/ProductModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductFromShopAModel>>> GetProductModel()
        {
            return await _context.ProductFromShopAModel.Include(nameof(Models.ProductFromShopAModel.Item)) //caused a cyle
                                    .ToListAsync();
        }

        // GET: api/ProductModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductFromShopAModel>> GetProductModel(int id)
        {
            var productModel = await _context.ProductFromShopAModel.FindAsync(id);

            if (productModel == null)
            {
                return NotFound();
            }

            return productModel;
        }

        // PUT: api/ProductModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductModel(int id, ProductFromShopAModel productModel)
        {
            if (id != productModel.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(productModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductModelExists(id))
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

        // POST: api/ProductModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductFromShopAModel>> PostProductModel(ProductFromShopAModel productModel)
        {
            _context.ProductFromShopAModel.Add(productModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductModel", new { id = productModel.ProductId }, productModel);
        }

        // DELETE: api/ProductModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductModel(int id)
        {
            var productModel = await _context.ProductFromShopAModel.FindAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }

            _context.ProductFromShopAModel.Remove(productModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductModelExists(int id)
        {
            return _context.ProductFromShopAModel.Any(e => e.ProductId == id);
        }
        */
    }
}
