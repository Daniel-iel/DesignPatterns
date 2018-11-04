using System;

namespace _1_Strategy
{
    class Program
    {
#pragma warning disable RECS0154 // Parameter is never used
        static void Main(string[] args)
#pragma warning restore RECS0154 // Parameter is never used
        {
            IOperation multiply = new OperationMultiply();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{2} x {i} = {multiply.Calc(2, i)}");
            }

            IOperation substract = new OperationSubstract();
            Console.WriteLine($"10 - 4 = {substract.Calc(10, 4)}");

            Context contextMultiply = new Context(multiply);
            Console.WriteLine($"10 x 4 = {contextMultiply.ExecuteOperation(10, 4)}");

            Context contextSubtract = new Context(substract);

            Console.ReadKey();
        }
    }
}
