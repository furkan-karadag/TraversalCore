using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

		[HttpGet]
        public async Task <IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditVİewModel userEditVİewModel = new UserEditVİewModel();
			userEditVİewModel.name = values.Name;
			userEditVİewModel.surname = values.Surname;
			userEditVİewModel.phonenumber = values.PhoneNumber;
			userEditVİewModel.mail=values.Email;
			return View(userEditVİewModel);
		}
	}
}
