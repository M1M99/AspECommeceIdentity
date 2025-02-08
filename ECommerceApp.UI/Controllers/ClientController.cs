using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.UI.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            TempData["user"] = User.Identity.Name;
            return RedirectToAction("Index", "Product");
        }
    }
}
