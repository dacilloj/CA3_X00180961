using Microsoft.AspNetCore.Mvc;
using ShopMVC.Service;

namespace ShopMVC.Controllers
{
    public class ShopAController : Controller
    {
        private readonly ShopAService _service;

        public ShopAController(ShopAService service)
        {
            _service = (service ?? throw new ArgumentNullException(nameof(service)));
        }

        public async Task<IActionResult> ShopAIndex()
        {
            var items = await _service.Find();
            return View(items);
        }
    }
    
}
