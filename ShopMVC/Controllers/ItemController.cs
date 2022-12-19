using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using ShopMVC.Service;
using static NuGet.Packaging.PackagingConstants;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System;

namespace ShopMVC.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
        {
            _service = (service ?? throw new ArgumentNullException(nameof(service)));
        }

        public async Task<IActionResult> ItemIndex()
        {
            var items = await _service.Find();
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }
            
    }       



        
}
