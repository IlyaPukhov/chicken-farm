namespace ChickenFarm.Notification
{
    public class SmsNotificationDecorator(IDatabaseObserver observer) : NotificationDecorator(observer)
    {
        public override void Notify(string message)
        {
            base.Notify(message);
            SendSms(message);
        }

        private static void SendSms(string message)
        {
            Console.WriteLine($"SMS. " + message);
        }
    }
}
