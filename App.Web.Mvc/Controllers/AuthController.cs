using App.Web.Mvc.App.Data;
using App.Web.Mvc.App.Entity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    { private readonly AppDbContext _dataContext;

		public AuthController(AppDbContext dataContext)
		{
			_dataContext = dataContext;
		}
        public IActionResult Register()
        {
          User user=new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
        if (user == null) 
        {
         return RedirectToAction("Index", "Home");
        }
        if(user!=null) 
        {
         _dataContext.Add(user);
         _dataContext.SaveChanges();
        return RedirectToAction("Index");
        }
        return View(user);
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgotPassword( string redirecUrl)
        {
            return View();
        }
    }
}
