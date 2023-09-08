using App.Web.Mvc.App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents
{
    public class Slider: ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public Slider(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var postList=_dbContext.Post.Include(p => p.CategoryPosts).ToList();
            return View(postList);
        }
    }
}
