using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamLab2
{
    class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Event triggered"));
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs arg)
        {
            EventHandler<CustomEventArgs> raiseEvent = RaiseCustomEvent;
            if (raiseEvent != null)
            {
                raiseEvent(this, arg);
            }
        }
    }
}
