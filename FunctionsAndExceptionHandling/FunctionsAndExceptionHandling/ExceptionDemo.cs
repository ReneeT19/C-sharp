using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    class ExceptionDemo
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
            //only one catch block will be caught at a time
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
                GC.Collect();
            }
            Console.ReadLine();
        }
    }
}
