﻿using ChickenFarm.Models;

namespace ChickenFarm.Notification
{
    public class NotificationService : IDatabaseObserver
    {

        public void UpdateNotify(Chicken chicken)
        {
            Console.WriteLine($"Уведомление: Курочка из клетки {chicken.Position.GetString()} была обновлена!");
        }
    }
}
