using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorialService = new FactorialService();
            while (true)
            {
                Console.WriteLine("Please enter an integer");
                string input = Console.ReadLine();
                try
                {
                    Console.WriteLine(factorialService.Process(input));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}