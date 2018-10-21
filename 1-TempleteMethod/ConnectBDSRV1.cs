using System;

namespace _1_TempleteMethod
{
    public class ConnectBDSRV1 : ConnectionTemplete
    {
        public override void ConnectOracle(string connectionString)
        {
            Console.WriteLine("Connecting to Oracle");
        }

        public override void ConnectSQL(string connectionString)
        {
            Console.WriteLine("Connecting to SQL");
        }
    }
}
