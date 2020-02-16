using Caliburn.Micro;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class FirstViewModel : Screen
    {
        private string _displayName = "First View Model";
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

        public FirstViewModel(TheSameViewModel theSameViewModel)
        {
            TheSameViewModel = theSameViewModel;
        }
    }
}
