using System;

namespace _1_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory();
            var sqlConnection = connectionFactory.Initialize(EConnection.SQL);
            sqlConnection.Connect();

            var oracleConnection = connectionFactory.Initialize(EConnection.Oracle);
            oracleConnection.Connect();
        }
    }

    class ConnectionFactory
    {
        public IConnection Initialize(EConnection con)
        {

            switch (con)
            {
                case EConnection.Oracle:
                    return new Oracle();
                case EConnection.SQL:
                    return new SQL();
                default:
                    throw new Exception("Connection not found");
            }
        }
    }

    class SQL : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("SQL Connected");
        }
    }

    class Oracle : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Oracle Connected");
        }
    }

    internal interface IConnection
    {
        void Connect();
    }

    public enum EConnection
    {
        Oracle,
        SQL
    }
}
