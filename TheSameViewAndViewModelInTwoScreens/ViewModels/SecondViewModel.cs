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
        public TheSameViewModel TheSameViewModel { get; }

        public SecondViewModel(TheSameViewModel theSameViewModel)
        {
            TheSameViewModel = theSameViewModel;
        }
    }
}
