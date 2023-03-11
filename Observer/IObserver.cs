namespace Observer
{
    internal interface IObserver
    {
        //This is another way todo it, you pass the ISubject property to the observable 
        //and the IObsevable child subcribe via constructor to the subject

        //public ISubject Subject { get; set; }
        //public void Update();
        public void Update(ISubject subject);
    }
}
