using App.Web.Mvc.App.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
    public class Header : ViewComponent
    {private readonly AppDbContext _dbContext;
        public Header(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
