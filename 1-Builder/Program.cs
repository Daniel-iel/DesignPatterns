using System;

namespace _1_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectBuilder sqlBuiler = new ConnectBuilder()
            .ConnectSQL("SQL Connection")
            .BuildConnection()
            .CloseConnection();

            ConnectBuilder oracleBuilder = new ConnectBuilder()
            .ConnectOracle("Oracle Connection")
            .BuildConnection()
            .CloseConnection();

            Console.WriteLine("Hello World!");
        }
    }

    public class ConnectBuilder
    {
        public string ConnectionString { get; private set; }
        public Connect Connection { get; private set; }

        public ConnectBuilder ConnectOracle(string connectionString)
        {
            this.ConnectionString = connectionString;

            return this;
        }

        public ConnectBuilder ConnectSQL(string connectionString)
        {
            this.ConnectionString = connectionString;

            return this;
        }

        public ConnectBuilder CloseConnection()
        {
            if (Connection == null)
            {
                return this;
            }

            this.Connection.Close();

            return this;
        }

        public ConnectBuilder BuildConnection()
        {
            if (Connection != null)
            {
                Console.WriteLine("You've been connected!!\n");

                return this;
            }

            this.Connection = new Connect(this.ConnectionString);
            this.Connection.TryConnect();

            return this;
        }
    }

    public class Connect
    {
        private readonly string conectionString;

        public Connect(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public void Close()
        {
            Console.WriteLine($"Close Connection {conectionString} \n");
        }

        public void TryConnect()
        {
            Console.WriteLine($"You've been connect in {conectionString}\n");
        }
    }
}
