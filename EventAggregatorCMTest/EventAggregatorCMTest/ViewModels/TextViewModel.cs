using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace EventAggregatorCMTest.ViewModels
{
    public class TextViewModel : Screen, IHandle<ChangeTextMessage>
    {
        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                NotifyOfPropertyChange();
            }
        }
        public TextViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
            Text = "No button pressed";
        }

        public void Handle(ChangeTextMessage message)
        {
            Text = message.Text;
        }
    }
}
