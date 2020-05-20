using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace EventAggregatorCMTest.ViewModels
{
    public class ChangeTextMessage
    {
        public string Text
        {
            get;
            private set;
        }

        public ChangeTextMessage(string text)
        {
            Text = text;
        }
    }

    public class ButtonViewModel
    {
        private readonly IEventAggregator _eventAggregator;
        public ButtonViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void Button1()
        {
            _eventAggregator.PublishOnUIThread(new ChangeTextMessage("Button 1 Pressed"));
        }

        public void Button2()
        {
            _eventAggregator.PublishOnUIThread(new ChangeTextMessage("Button 2 Pressed"));
        }

        public void Button3()
        {
            _eventAggregator.PublishOnUIThread(new ChangeTextMessage("Button 3 Pressed"));
        }
    }
}
