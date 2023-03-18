using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    internal class Subject : ISubject
    {
        private List<IObserver> observers = new();
        public int State { get; set; }

        //private int _state;

        //In that way yu can subcribe automatically to the subject when is setter 
        //public int State
        //{ 
        //    get 
        //    {
        //        return _state; 
        //    } 
        //    set 
        //    {
        //        _state = value;
        //
        //        Notify();
        //    } 
        //}

        public void Subscribe(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine("Subject: Subscribe an observer.");
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException();
            }
            observers.Remove(observer);
            Console.WriteLine("Subject: Unsubscribe an observer.");
        }


        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }


        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(20);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
