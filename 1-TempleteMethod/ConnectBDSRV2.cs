using System;

namespace _1_TempleteMethod
{
    public class ConnectBDSRV2 : ConnectionTemplete
    {
        public override void ConnectOracle(string connectionString)
        {
            Console.WriteLine("Connecting to oracle");
        }

        public override void ConnectSQL(string connectionString)
        {
            Console.WriteLine("Connecting to sql");
        }
    }
}
