using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Strategy
{
    public interface IOperation
    {
        decimal Calc(int num1, int num2);
    }
}
