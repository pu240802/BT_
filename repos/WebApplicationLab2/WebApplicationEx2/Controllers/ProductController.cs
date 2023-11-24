using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEx2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowProduct()
        {
            return View();
        }
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        public ActionResult DetailsProduct(string productName, int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }
    }
}
