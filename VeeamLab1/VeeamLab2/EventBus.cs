using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamLab2
{
    class EventBus
    {

        public event EventHandler<CustomEventArgs> NewEvent;

        public EventBus(Publisher pub)
        {
            pub.RaiseCustomEvent += HadleCustomEvent;
        }

        void HadleCustomEvent(object sender, CustomEventArgs arg)
        {
            OnNewEvent(arg);
        }

        protected virtual void OnNewEvent(CustomEventArgs arg)
        {
            NewEvent?.Invoke(this, arg);
        }
    }
}
