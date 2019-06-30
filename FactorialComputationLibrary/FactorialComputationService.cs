using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialComputationLibrary
{
    public class FactorialComputationService : IFactorialComputationService
    {
        public int GetFactorial(int input)
        {
            if (input < 0)
            {
                throw new ArithmeticException("Factorial of negative integers is undefined");
            }
            else if (input == 0)
            {
                return 1;
            }
            else
            {
                // we raise an exception on overflows
                return checked(input * GetFactorial(input - 1));
            }
        }
    }
}
