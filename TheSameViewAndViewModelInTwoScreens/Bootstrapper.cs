using System.Windows;
using Caliburn.Micro;
using TheSameViewAndViewModelInTwoScreens.ViewModels;

namespace TheSameViewAndViewModelInTwoScreens
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
           base.OnStartup(sender, e);
            DisplayRootViewFor<AppMainViewModel>();
        }
    }
}
