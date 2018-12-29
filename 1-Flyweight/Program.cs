using System;
using System.Collections.Generic;

namespace _1_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var connections = new Connections();

            connections.GetConnection("oracle");
            connections.GetConnection("sql");
            
            connections.GetConnection("oracle");
            connections.GetConnection("sql");
            
            connections.GetConnection("oracle");
            connections.GetConnection("sql");

            Console.WriteLine("Hello World!");
        }
    }

    public class Connections
    {
        readonly Dictionary<string, IConnection> connections = new Dictionary<string, IConnection>()
        {
            { "sql", new SQL() },
            { "oracle", new Oracle() },
        };

        public void GetConnection(string db)
        {
            connections[db].Connect();
        }
    }

    internal class Oracle : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Oracle connection");
        }
    }

    internal class SQL : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("SQL connection");
        }
    }

    internal interface IConnection
    {
        void Connect();
    }
}
