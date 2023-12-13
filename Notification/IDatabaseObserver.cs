using ChickenFarm.Models;

namespace ChickenFarm.Notification
{
    public interface IDatabaseObserver
    {
        void UpdateNotify(Chicken chicken);
    }
}
