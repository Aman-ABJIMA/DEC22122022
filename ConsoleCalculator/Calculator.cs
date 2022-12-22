using System;

namespace ConsoleCalculator
{
    public class Calculator
    {

        //Method 1:
        public int Calculate(int number1, int number2, string? operation)
        {
           // throw new ArgumentNullException(paramName: nameof(operation));
            //Below throwing exception in an expression
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
          
            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1,number2);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("...logging...");
                    //throw ex;
                    //throw new ArithmeticException("An error occured during calculation\n", ex);
                    throw new CalculationException(ex);
                }
                
            }
            else
            {
                throw new CalculationException(nonNullOperation);

               //throw new ArgumentOutOfRangeException(nameof(operation));
                //Console.WriteLine("Unknown operation.");
                //return 0;
            }
        }

        //Method 2:
        private int Divide(int number, int divisor) => number / divisor; 
    }
}

