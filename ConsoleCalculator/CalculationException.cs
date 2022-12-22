using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculationException : Exception
    {
        private const string DefaultMessage = "An error occurred during calculation. Ensure that the values are within the valid ranges for the requested operation.";

        public CalculationException() : base(DefaultMessage) 
        { 
        
        }
        public CalculationException(string message) : base(message) 
        {
        
        
        }

        public CalculationException(Exception innerException) : base(DefaultMessage,innerException)
        {

        }
        public CalculationException(string message,Exception innerException): base(message,innerException) 
        {
        
        }
    }
}
