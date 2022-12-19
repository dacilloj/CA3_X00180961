using Microsoft.AspNetCore.Mvc;
using ShopMVC.Service;

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


    }
}
