namespace _1_Strategy
{
    public class Context
    {
        private IOperation operation;

        public Context(IOperation operation)
        {
            this.operation = operation;
        }

        public decimal ExecuteOperation(int num1, int num2)
        {
            return operation.Calc(num1, num2);
        }
    }
}
