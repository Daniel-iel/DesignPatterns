using System;
using System.Collections.ObjectModel;

namespace _1_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var connect = new Connect();
            connect.AddNotification(new SendEmail());
            connect.AddNotification(new SendSms());
            connect.TryConnect();
            connect.EndConnect();

        }
    }

    public class Connect
    {
        readonly ObservableCollection<Notification> notifications = new ObservableCollection<Notification>();

        public void TryConnect()
        {
            Console.WriteLine($"Connected {new Guid()}");

            SendNotify();
        }

        public void EndConnect()
        {
            Console.WriteLine("End Connection");

            SendNotify();
        }

        public void AddNotification(Notification teste)
        {
            notifications.Add(teste);
        }

        private void SendNotify()
        {
            foreach (var notification in notifications)
            {
                notification.Notify();
            }
        }
    }

    public class SendEmail : Notification
    {
        public override void Notify()
        {
            Console.WriteLine("Sending Email");
        }
    }

    public class SendSms : Notification
    {
        public override void Notify()
        {
            Console.WriteLine("Sending Sms");
        }
    }

    public abstract class Notification
    {
        public abstract void Notify();
    }
}
