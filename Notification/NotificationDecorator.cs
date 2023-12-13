namespace ChickenFarm.Notification
{
    public abstract class NotificationDecorator : IDatabaseObserver
    {
        private readonly IDatabaseObserver _observer;

        public NotificationDecorator(IDatabaseObserver observer)
        {
            _observer = observer;
        }

        public virtual void Notify(string message)
        {
            _observer.Notify(message);
        }
    }
}
