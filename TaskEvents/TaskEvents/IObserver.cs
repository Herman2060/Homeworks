namespace TaskEvents
{
    public interface IObserver
    {
        void Update(IObservable subject);
    }
}