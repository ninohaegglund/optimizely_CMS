using Microsoft.AspNetCore.Mvc;
using Optimizely_CMS.Models.Pages;
using Optimizely_CMS.Models.ViewModels;

namespace Optimizely_CMS.Controllers
{
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        public IActionResult Index(ArticlePage currentPage)
        {
            var model = new ArticlePageViewModel(currentPage);

            return View(model);
        }
    }
}