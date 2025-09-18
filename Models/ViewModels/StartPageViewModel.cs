using Optimizely_CMS.Models.Pages;

namespace Optimizely_CMS.Models.ViewModels
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}