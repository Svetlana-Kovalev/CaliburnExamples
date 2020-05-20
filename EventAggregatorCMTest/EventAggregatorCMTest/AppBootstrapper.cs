using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using EventAggregatorCMTest.ViewModels;

namespace EventAggregatorCMTest
{
    public class AppBootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer _container = new SimpleContainer();

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container.Instance<IWindowManager>(new WindowManager());
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.Singleton<AppMainViewModel>();
            _container.Singleton<ButtonViewModel>();
            _container.Singleton<TextViewModel>();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            Dictionary<string, object> window_settings = new Dictionary<string, object>();
            window_settings.Add("WindowState", System.Windows.WindowState.Maximized);
            // double width = Settings.Default.screen_width;  //Previous window width 
            // double height = Settings.Default.screen_height; //Previous window height

            //            double screen_width = System.Windows.SystemParameters.MaximumWindowTrackWidth;
            //            double screen_height = System.Windows.SystemParameters.MaximumWindowTrackHeight;
            //
            //            //if (width > screen_width) width = (screen_width - 10);
            //            // if (height > screen_height) height = (screen_height - 10);
            //
            //            Dictionary<string, object> window_settings = new Dictionary<string, object>();

            //window_settings.Add("Width", screen_width);
            //window_settings.Add("Height", screen_height);
            DisplayRootViewFor<AppMainViewModel>(window_settings);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            Assembly[] selectAssemblies = { Assembly.GetExecutingAssembly() };
            return selectAssemblies;
        }
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }

}
