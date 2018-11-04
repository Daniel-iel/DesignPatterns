using System;

namespace _1_State
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionWrapper wrapper = new ConnectionWrapper();

            IStateConnection openState = new Open();
            openState.Connection(wrapper);
            wrapper.GetState();

            IStateConnection closeState = new Close();
            closeState.Connection(wrapper);
            wrapper.GetState();

            Console.ReadKey();
        }
    }

    public class ConnectionWrapper
    {
        IStateConnection currenteState;

        public ConnectionWrapper()
        {
            currenteState = null;
        }

        public void SetState(IStateConnection state)
        {
            currenteState = state;
        }

        public IStateConnection GetState()
        {
            return currenteState;
        }
    }

    public interface IStateConnection
    {
        void Connection(ConnectionWrapper wrapper);
    }

    public class Open : IStateConnection
    {
        public void Connection(ConnectionWrapper wrapper)
        {
            wrapper.SetState(this);
            Console.WriteLine("Openning connection");
        }
    }

    public class Close : IStateConnection
    {
        public void Connection(ConnectionWrapper wrapper)
        {
            wrapper.SetState(this);
            Console.WriteLine("Closing connection");
        }
    }
}
