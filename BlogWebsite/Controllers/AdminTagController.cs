using BlogWebsite.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class AdminTagController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;
            return View("Add");
        }
    }
}
