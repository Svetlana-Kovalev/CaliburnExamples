using Caliburn.Micro;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class SecondViewModel : Screen
    {
        private string _displayName = "Second View Model";
        public override string DisplayName
        {
            get => _displayName;
            set
            {
                _displayName = value;
                NotifyOfPropertyChange();
            }
        }

        private TheSameViewModel _theSameViewModel;
        public TheSameViewModel TheSameViewModel
        {
            get => _theSameViewModel;
            set
            {
                _theSameViewModel = value;
                NotifyOfPropertyChange();
            }
        }

        public SecondViewModel(TheSameViewModel theSameViewModel)
        {
            TheSameViewModel = theSameViewModel;
        }
    }
}
