namespace _1_Strategy
{
    public class OperationSubstract : IOperation
    {
        public decimal Calc(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
