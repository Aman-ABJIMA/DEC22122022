using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException
            += new UnhandledExceptionEventHandler(HandleException);
            WriteLine("Enter first number:");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number:");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation:");
            string? operation = ReadLine();


            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result); //function calling
            }
            catch(ArgumentNullException ex) when (ex.ParamName=="operation") 
            {
             WriteLine("Operation was not provided\n"+ex);
            
            
            }
            catch (ArgumentNullException ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Operation is not provided!!!\n" + ex);
                

            }
            catch (CalculationOperationNotSupportedException ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Calculation not supported Exception Cought!!!\n" + ex.Operation);
                WriteLine(ex);
            }
            catch(CalculationException ex)
            {
                WriteLine($"CalculaionException Cought");
                WriteLine(ex);
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Sorry!!\nsomething went wrong\n" + ex);

            }
            finally 
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("...executed successfully...");
                ForegroundColor = ConsoleColor.White;
            }

          
            
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry there was a problem and we need to close.\nDetails:{e.ExceptionObject}");
        }

        private static void DisplayResult(int result) => WriteLine($"Result is: {result}");
    }
}


// FROM C# 9 "Top-level statements":

//using ConsoleCalculator;
//using static System.Console;


//WriteLine("Enter first number");
//int number1 = int.Parse(ReadLine());

//WriteLine("Enter second number");
//int number2 = int.Parse(ReadLine());

//WriteLine("Enter operation");
//string operation = ReadLine().ToUpperInvariant();


//var calculator = new Calculator();
//int result = calculator.Calculate(number1, number2, operation);
//DisplayResult(result);


//WriteLine("\nPress enter to exit.");
//ReadLine();


//void DisplayResult(int result)
//{
//    WriteLine($"Result is: {result}");
//}


