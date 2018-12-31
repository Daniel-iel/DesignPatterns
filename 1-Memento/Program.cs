using System;
using System.Collections.Generic;

namespace _1_Memento
{
    class Program
    {
        static void Main(string[] args)
        {

            Connection con = new Connection();
            CareTaker careTaker = new CareTaker();

            con.SetState(EConnection.Open);
            careTaker.Add(con.SaveState());

            con.SetState(EConnection.InExecution);
            careTaker.Add(con.SaveState());

            con.SetState(EConnection.Close);
            careTaker.Add(con.SaveState());

            Console.WriteLine(con.GetState());

            con.GetStateMemento(careTaker.Get(0));
            Console.WriteLine(con.GetState());

            con.GetStateMemento(careTaker.Get(2));
            Console.WriteLine(con.GetState());

            Console.WriteLine("Hello World!");
        }
    }


    public class ConnectionMemento
    {
        private readonly EConnection econnection;

        public ConnectionMemento(EConnection econnection)
        {
            this.econnection = econnection;
        }

        public EConnection GetState()
        {
            return econnection;
        }
    }

    public class Connection
    {
        private EConnection econnection;

        public void SetState(EConnection econnection)
        {
            this.econnection = econnection;
        }

        public EConnection GetState()
        {
            return econnection;
        }

        public ConnectionMemento SaveState()
        {
            return new ConnectionMemento(econnection);
        }

        public void GetStateMemento(ConnectionMemento connectionMemento)
        {
            econnection = connectionMemento.GetState();
        }

    }

    public class CareTaker
    {
        private List<ConnectionMemento> mementoList = new List<ConnectionMemento>();

        public void Add(ConnectionMemento state)
        {
            mementoList.Add(state);
        }

        public ConnectionMemento Get(int index)
        {
            return mementoList[index];
        }
    }

    public enum EConnection
    {
        Open,
        InExecution,
        Close
    }
}
