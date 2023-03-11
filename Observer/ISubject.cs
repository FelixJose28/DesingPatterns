namespace Observer
{
    internal interface ISubject
    {
        public void Notify();
        public void Subscribe(IObserver observer);
        public void Unsubscribe(IObserver observer);
    }
}
