using System;

namespace _1_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var tryConnection = new TryConnection();
            var resultConnection = tryConnection.Connect(10);

            Console.WriteLine($"{resultConnection}");
            Console.ReadKey();
        }
    }
}
