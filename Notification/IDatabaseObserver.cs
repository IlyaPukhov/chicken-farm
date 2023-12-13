namespace ChickenFarm.Notification
{
    public interface IDatabaseObserver
    {
        void Notify(string message);
    }
}
