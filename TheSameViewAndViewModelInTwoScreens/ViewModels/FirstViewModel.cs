using System.Threading;
using System.Threading.Tasks;
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

        public FirstViewModel(TheSameViewModel theSameViewModel)
        {
            TheSameViewModel = theSameViewModel;
        }
    }
}
