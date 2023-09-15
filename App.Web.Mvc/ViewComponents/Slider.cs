using App.Web.Mvc.App.Data;
using App.Web.Mvc.App.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents
{
	public class Slider : ViewComponent
	{
		private readonly AppDbContext _dbContext;
		public Slider(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IViewComponentResult Invoke()
		{
			return View(); // sorgular yapılacak
		}
	}
}
