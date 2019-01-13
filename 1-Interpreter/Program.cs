using System;
using System.Collections.Generic;

namespace _1_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.StrConnection = "Oracle connection";

            var list = new List<AbstractExpression>
            {
                new OracleExpression(),
                new SQLExpression()
            };

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }
    }

    internal class OracleExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called OracleExpression.Interpret");
        }
    }

    internal class SQLExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called SQLExpression.Interpret");
        }
    }

    internal abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    internal class Context
    {
        private string _strConnection;

        public string StrConnection
        {
            get { return _strConnection; }
            set { _strConnection = value; }
        }

    }
}
