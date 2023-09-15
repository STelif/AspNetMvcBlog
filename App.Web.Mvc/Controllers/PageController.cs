using App.Web.Mvc.App.Data;
using Microsoft.AspNetCore.Mvc;


namespace App.Web.Mvc.Controllers
{
	public class PageController : Controller
	{
		private readonly AppDbContext _dataContext;
		public PageController(AppDbContext dataContext)
		{
			_dataContext = dataContext;
		}

		public IActionResult Detail(int id)
		{
			if (id == 0)
			{
				return RedirectToAction(nameof(Index));
			}
			var pages = _dataContext.Page.Where(p=> p.Id == id).ToList();
			if(pages is  null) 
			{
				return RedirectToAction(nameof(Index));
			}
			return View(pages);
		}
	}
}
