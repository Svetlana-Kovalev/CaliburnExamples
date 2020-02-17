using Caliburn.Micro;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class TheSameViewModel : Screen
    {
        public TheSameViewModel()
        {
            
        }
        private string _displayName = "The Same View Model";
        public override string DisplayName
        {
            get => _displayName;
            set
            {
                _displayName = value;
                NotifyOfPropertyChange();
            }
        }
        public override object GetView(object context = null)
        {
            return null;
        }
    }
}
