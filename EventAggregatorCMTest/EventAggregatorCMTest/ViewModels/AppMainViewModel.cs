using Caliburn.Micro;

namespace EventAggregatorCMTest.ViewModels
{
    public class AppMainViewModel : Screen
    {
        public ButtonViewModel ButtonViewModel { get; set; }
        public TextViewModel TextViewModel { get; set; }
        public AppMainViewModel(IEventAggregator eventAggregator, ButtonViewModel buttonViewModel, TextViewModel textViewModel)
        {
            ButtonViewModel = buttonViewModel;
            TextViewModel = textViewModel;
        }
    }
}
