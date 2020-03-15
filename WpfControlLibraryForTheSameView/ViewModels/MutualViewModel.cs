using Caliburn.Micro;

namespace WpfControlLibraryForTheSameView.ViewModels
{
    public class MutualViewModel : Screen
    {
        private string _displayName = "Mutual View Model";
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
