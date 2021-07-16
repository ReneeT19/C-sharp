using System;

namespace FunctionsAndExceptionHandling
{
    class ExcepDemo
    {
        static void Main()
        {
           
            try
            {
                Console.Write("Enter a First Number:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter a First Number:");
                int b = int.Parse(Console.ReadLine());
                double result = a / b;
                Console.WriteLine(result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am in finally");
                GC.Collect();
            }

            Console.ReadLine();
        }
    }
}
