using System.Linq;
using Caliburn.Micro;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class AppMainViewModel : Conductor<Screen>.Collection.OneActive
    {
        public BindableCollection<Screen> Screens { get; set; }
        //private bool _firstItemSelected;
        public AppMainViewModel()
        {
            TheSameViewModel theSameViewModel = new TheSameViewModel();
            //TheSameViewModel theSameViewModel2 = new TheSameViewModel();
            Screens = new BindableCollection<Screen>
            {
                new FirstViewModel(theSameViewModel), new SecondViewModel(theSameViewModel)
            };
           // _firstItemSelected = true;
            //ActiveItem = Screens.First();
        }

        public void SelectionChanged(object o)
        {
            //if (_firstItemSelected)
            //{
            //    ActiveItem = Screens[1];
            //    _firstItemSelected = false;
            //}
            //else
            //{
            //    ActiveItem = Screens.First();
            //    _firstItemSelected = true;
            //}
            Refresh();
            
        }
    }
}
