using Optimizely_CMS.Models.Pages;

namespace Optimizely_CMS.Models.ViewModels
{
    public class ArticlePageViewModel : PageViewModel<ArticlePage>
    {
        public ArticlePageViewModel(ArticlePage currentPage) : base(currentPage)
        {
        }
    }
}