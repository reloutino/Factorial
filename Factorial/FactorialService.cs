using FactorialComputationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class FactorialService
    {
        IFactorialComputationService FactorialComputationService;

        public FactorialService()
        {
            FactorialComputationService = new FactorialComputationService();
        }

        // this example is too simple to require a dependancy injection framework --
        // but we allow a constructor injecton for unit tests
        public FactorialService(IFactorialComputationService factorialComputationService)
        {
            FactorialComputationService = factorialComputationService;
        }

        public int Process(string input)
        {
            if (Int32.TryParse(input, out int parsedInput))
            {
                return FactorialComputationService.GetFactorial(parsedInput);
            }
            else
            {
                throw new FormatException(String.Format("{0} is not an integer", input));
            }
        }
    }
}
