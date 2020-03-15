using Caliburn.Micro;

namespace WpfControlLibraryForTheSameView.ViewModels
{
    public class SecondForMutualViewModel : Screen
    {
        private string _displayName = "Second For Mutual View Model";
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
        public SecondForMutualViewModel(MutualViewModel mutualViewModel)
        {
            MutualViewModel = mutualViewModel;
        }
    }
}
