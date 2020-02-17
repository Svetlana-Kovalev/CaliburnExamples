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
        public override object GetView(object context = null)
        {

            return base.GetView(context);
        }

        protected override Task OnInitializeAsync(CancellationToken cancellationToken)
        {
            return base.OnInitializeAsync(cancellationToken);
        }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }
    }
}
