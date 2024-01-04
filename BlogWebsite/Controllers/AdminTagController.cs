using BlogWebsite.Data;
using BlogWebsite.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using BlogWebsite.Models.DomainModel;

namespace BlogWebsite.Controllers
{
    public class AdminTagController : Controller
    {
        private readonly AppDbContext dbContext;

        public AdminTagController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            var tags = new Tags()
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName

            };
            dbContext.Tags.Add(tags);
            dbContext.SaveChanges();

            return View("Add");
        }
    }
}
