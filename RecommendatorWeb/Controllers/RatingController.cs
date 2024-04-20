using Microsoft.AspNetCore.Mvc;

namespace RecommendatorWeb.Controllers
{
    public class RatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
