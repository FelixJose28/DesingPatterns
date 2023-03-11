using System;

namespace Observer
{
    internal class ObserverA : IObserver
    {
        //public ISubject Subject { get; set; }

        //public ObserverA(ISubject Subject)
        //{
        //    this.Subject = Subject;
        //    this.Subject.Subscribe(this);
        //}

        public void Update(ISubject subject)
        {

            Console.WriteLine("Into ObserverA");
            if ((subject as Subject).State <= 5)
            {
                Console.WriteLine("ObserverA: Reacted to the event.");
            }
        }
    }
}
