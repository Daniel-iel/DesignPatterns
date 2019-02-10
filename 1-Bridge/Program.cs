namespace _1_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Message habbitMQMessage = new HabbitMQMessage();
            Qeue habbitMQeue = new Qeue(habbitMQMessage);
            habbitMQeue.SendMessage();

            Message azureServiceBusMessage = new AzureServiceBusMessage();
            Qeue azureServiceBusQeue = new Qeue(azureServiceBusMessage);
            azureServiceBusQeue.SendMessage();
        }
    }

    abstract class Message
    {
        public abstract void SendMessage();
    }

    class Qeue
    {
        private readonly Message message;

        public Qeue(Message message)
        {
            this.message = message;
        }

        public void SendMessage()
        {
            message.SendMessage();
        }
    }

    class HabbitMQMessage : Message
    {
        public override void SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }

    class AzureServiceBusMessage : Message
    {
        public override void SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
