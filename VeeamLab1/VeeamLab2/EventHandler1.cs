using System;

namespace VeeamLab2
{
    class EventHandler1
    {
        public string NameHandler { get; set; }
        public EventHandler1(string nameHandler, EventBus bus)
        {
            NameHandler = nameHandler;
            bus.NewEvent += HandleEvent;
        }

        private void HandleEvent(object sender, CustomEventArgs arg)
        {
            Console.WriteLine($"{this.GetType()} {NameHandler} {arg.Message}");
        }

        public void Unregister(EventBus bus)
        {
            bus.NewEvent -= HandleEvent;
        }
    }
}
