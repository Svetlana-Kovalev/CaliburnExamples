using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using Caliburn.Micro;
using TheSameViewAndViewModelInTwoScreens.ViewModels;

namespace TheSameViewAndViewModelInTwoScreens
{
    public class Bootstrapper : BootstrapperBase
    {
        const string WpfControlLibraryForTheSameView = "WpfControlLibraryForTheSameView.dll";

        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
           base.OnStartup(sender, e);
            DisplayRootViewFor<AppMainViewModel>();
        }
        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            Assembly[] selectAssemblies = { Assembly.GetExecutingAssembly() };
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (path != null)
            {
                Assembly[] assemblies =
                {
                    Assembly.LoadFile(Path.Combine(path, WpfControlLibraryForTheSameView)),
                };
                IEnumerable<Assembly> concatAssemblies = selectAssemblies.Concat(assemblies);
                return concatAssemblies;
            }
            return selectAssemblies;
        }
    }
}
