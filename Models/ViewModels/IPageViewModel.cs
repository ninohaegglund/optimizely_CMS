using Optimizely_CMS.Models.Pages;

namespace Optimizely_CMS.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; set; }
    }
}