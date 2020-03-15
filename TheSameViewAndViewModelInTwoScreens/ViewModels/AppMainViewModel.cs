using Caliburn.Micro;
using WpfControlLibraryForTheSameView.ViewModels;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class AppMainViewModel : Conductor<Screen>.Collection.OneActive
    {
        public BindableCollection<Screen> Screens { get; set; }
        public AppMainViewModel()
        {
            TheSameViewModel theSameViewModel = new TheSameViewModel();
            MutualViewModel mutualViewModel = new MutualViewModel();
            FirstForMutualViewModel firstForMutualViewModel = new FirstForMutualViewModel(mutualViewModel);
            SecondForMutualViewModel secondForMutualViewModel = new SecondForMutualViewModel(mutualViewModel);
            Screens = new BindableCollection<Screen>
            {
                new FirstViewModel(theSameViewModel, mutualViewModel),
                new SecondViewModel(theSameViewModel, mutualViewModel),
                firstForMutualViewModel,
                secondForMutualViewModel,
                theSameViewModel,
                mutualViewModel
            };
        }

        public void SelectionChanged()
        {

        }
    }
}
