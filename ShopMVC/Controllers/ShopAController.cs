using Microsoft.AspNetCore.Mvc;

namespace ShopMVC.Controllers
{
    public class ShopAController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
