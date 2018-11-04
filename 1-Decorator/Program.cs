using System;

namespace _1_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator, add new feature in existe objects
            IConnect sql = new SQLConnect();
            sql.Connect();

            IConnect oracle = new Oracle();
            oracle.Connect();

            IConnect sqlValidate = new SQLValidateConnection(new SQLConnect());
            sqlValidate.Connect();

            IConnect oracleValidate = new OracleValidateConnection(new Oracle());
            oracleValidate.Connect();

            Console.ReadKey();
        }
    }

    public interface IConnect
    {
        void Connect();
    }

    public class OracleValidateConnection : ConectionValidate
    {
        private readonly IConnect otherConnection;

        public OracleValidateConnection(IConnect otherConnection) : base(otherConnection)
        {
            this.otherConnection = otherConnection;
        }

        public override void Connect()
        {
            base.Connect();
            ValidateMySQLConnection();
        }

        private void ValidateMySQLConnection()
        {
            Console.WriteLine("Validating ORacle Connection");
        }
    }

    public class SQLValidateConnection : ConectionValidate
    {
        private readonly IConnect otherConnection;

        public SQLValidateConnection(IConnect otherConnection) : base(otherConnection)
        {
            this.otherConnection = otherConnection;
        }

        public override void Connect()
        {
            base.Connect();
            ValidateMySQLConnection();
        }

        private void ValidateMySQLConnection()
        {
            Console.WriteLine("Validating SQL Connection");
        }
    }

    public abstract class ConectionValidate : IConnect
    {
        readonly IConnect otherConnection;

        protected ConectionValidate(IConnect otherConnection)
        {
            this.otherConnection = otherConnection;
        }

        public virtual void Connect()
        {
            this.otherConnection.Connect();
        }
    }

    public class SQLConnect : IConnect
    {
        public void Connect()
        {
            Console.WriteLine("The connection SQL was success!");
        }
    }

    public class Oracle : IConnect
    {
        public void Connect()
        {
            Console.WriteLine("The connection ORACLE was success!");
        }
    }
}
