using System;

namespace _1_ChainOfResponsibility
{
    class Program
    {
#pragma warning disable RECS0154 // Parameter is never used
        static void Main(string[] args)
#pragma warning restore RECS0154 // Parameter is never used
        {
            var tryConnection = new TryConnection();
            var resultConnection = tryConnection.Connect(10);

            Console.WriteLine($"{resultConnection}");
            Console.ReadKey();
        }
    }
}
