using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace TheSameViewAndViewModelInTwoScreens.ViewModels
{
    public class TheSameViewModel : Screen
    {
        public TheSameViewModel()
        {
            
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
