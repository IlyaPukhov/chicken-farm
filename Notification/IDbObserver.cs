using ChickenFarm.Models;

namespace ChickenFarm.Notification
{
    public interface IDbObserver
    {
        void UpdateNotify(Chicken chicken);
    }
}
