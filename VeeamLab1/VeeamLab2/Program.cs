using System;
using System.Collections.Generic;

namespace VeeamLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pub = new Publisher();
            var bus = new EventBus(pub);
            var handl11 = new EventHandler1("h11", bus);
            var handl12 = new EventHandler1("h12", bus);
            var handl21 = new EventHandler1("h21", bus);
            var handl22 = new EventHandler1("h22", bus);

            pub.DoSomething();
            Console.WriteLine();
            handl21.Unregister(bus);
            handl22.Unregister(bus);
            pub.DoSomething();
        }

        public static void Fun1()
        {
            Action[] delegates = new Action[2];
            int outside = 0;
            for (int index = 0; index < 2; index++)
            {
                int inside = 0;
                delegates[index] = delegate
                {
                    Console.WriteLine("({0},{1})", outside, inside);
                    outside++;
                    inside++;
                };
            }
            Action first = delegates[0];
            Action second = delegates[1];

            first();
            first();
            delegates[0]();

            second();
            second();
        }
    }

}
