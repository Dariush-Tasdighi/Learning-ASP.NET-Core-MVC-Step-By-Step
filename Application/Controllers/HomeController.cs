namespace Application.Controllers
{
	public class HomeController : Microsoft.AspNetCore.Mvc.Controller
	{
		public HomeController() : base()
		{
		}

		public Microsoft.AspNetCore.Mvc.ViewResult Index()
		{
			return View();
		}
	}
}
