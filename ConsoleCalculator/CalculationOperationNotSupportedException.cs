using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculationOperationNotSupportedException : CalculationException
    {
        private const string DefaultMessage = "Specified operation was out of the range of valid values";
        public string Operation { get; }

        public CalculationOperationNotSupportedException():base (DefaultMessage)
        { }

        public CalculationOperationNotSupportedException(Exception innerException) : base(DefaultMessage, innerException)
        { }


        public CalculationOperationNotSupportedException(string message,Exception innerException) : base(message, innerException)
        { }


        public CalculationOperationNotSupportedException(string operation) : base(DefaultMessage) => Operation = operation;


        public CalculationOperationNotSupportedException(string operation,string message) : base(DefaultMessage) => Operation = operation;

        public override string ToString()
        {
            if (Operation == null)
            {
                return base.ToString();
            }
            else
            {


                return base.ToString() + Environment.NewLine + $"Unsupported operation: {Operation}";
            }
        }






    }
}
