using GalaSoft.MvvmLight;
using GenericMvvmLight.Model;

namespace GenericMvvmLight.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService dataService;

        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string welcomeTitle = string.Empty;

        public string WelcomeTitle
        {
            get
            {
                return welcomeTitle;
            }
            set
            {
                Set(ref welcomeTitle, value);
            }
        }

        public MainViewModel(IDataService dataService)
        {
            this.dataService = dataService;
            this.dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        return;
                    }

                    WelcomeTitle = item.Title;
                });
        }

        public override void Cleanup()
        {
            // Clean up if needed
            base.Cleanup();
        }
    }
}