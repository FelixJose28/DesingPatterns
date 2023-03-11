using System;

namespace Observer
{
    internal class ObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Into ObserverB");
            if ((subject as Subject).State >= 6)
            {
                Console.WriteLine("ObserverB: Reacted to the event.");
            }
        }
    }
}
