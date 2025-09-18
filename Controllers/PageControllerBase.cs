using EPiServer.Web.Mvc;
using Optimizely_CMS.Models.Pages;

namespace Optimizely_CMS.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
    }
}
