using System;

namespace _1_TempleteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World by Templete method");

            ConnectionTemplete srv01 = new ConnectBDSRV1();
            srv01.Connect("192.168.100.12");
            
            ConnectionTemplete srv02 = new ConnectBDSRV1();
            srv02.Connect("192.168.10.100");

            Console.ReadKey();
        }
    }
}
