using Caliburn.Micro;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class AppMainViewModel : Conductor<Screen>.Collection.OneActive
    {
        public BindableCollection<Screen> Screens { get; set; }
        public AppMainViewModel()
        {
            TheSameViewModel theSameViewModel = new TheSameViewModel();
            Screens = new BindableCollection<Screen>
            {
                new FirstViewModel(theSameViewModel), new SecondViewModel(theSameViewModel), theSameViewModel
            };
        }

        public void SelectionChanged()
        {

        }
    }
}
