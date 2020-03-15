using Caliburn.Micro;

namespace WpfControlLibraryForTheSameView.ViewModels
{
    public class FirstForMutualViewModel : Screen
    {
        private string _displayName = "First For Mutual View Model";
        public override string DisplayName
        {
            get => _displayName;
            set
            {
                _displayName = value;
                NotifyOfPropertyChange();
            }
        }
        public MutualViewModel MutualViewModel { get; }

        public FirstForMutualViewModel(MutualViewModel mutualViewModel)
        {
            MutualViewModel = mutualViewModel;
        }
    }
}
