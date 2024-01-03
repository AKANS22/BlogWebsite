using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class BlogPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
