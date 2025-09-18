using Microsoft.AspNetCore.Mvc;
using Optimizely_CMS.Models.Pages;
using Optimizely_CMS.Models.ViewModels;

namespace Optimizely_CMS.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}