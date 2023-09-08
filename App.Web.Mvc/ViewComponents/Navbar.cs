using App.Web.Mvc.App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents
{
    public class Navbar: ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public Navbar(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var categories=_dbContext.Category.ToList();
            var pages=_dbContext.Page.ToList();

            return View();
        }
    }
}
