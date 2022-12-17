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
using System.ComponentModel.DataAnnotations;

namespace CA3_X00180961.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemModelsController : ControllerBase
    {
        private readonly IShopRepo _repo;

        public ItemModelsController(IShopRepo repo)
        {
            _repo = repo;
        }

        // GET: api/ItemModels
        [HttpGet]

        public ActionResult<IEnumerable<ItemModel>> GetItemModel()
        {
            //return await _context.ItemModel.Include(nameof(ItemModel.productFromShopAModel)) //caused a cycle
            //                               .Include(nameof(ItemModel.productFromShopBModel))

            //                               .ToListAsync();

            return _repo.GetItemModels().ToList();
        }



        //POST: api/ItemModels

        [HttpPost]
        public ActionResult<ItemModel> PostItemModel(ItemModel itemModel)
        {

            _repo.CreateItem(itemModel);
            return CreatedAtAction("GetItemModel", new { id = itemModel.ItemId }, itemModel);
        }

        [HttpDelete]
        public void DeleteItem(int id)
        {
            _repo.DeleteItem(id);

        }

      


        /*
        
        
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
        */
    }
}
