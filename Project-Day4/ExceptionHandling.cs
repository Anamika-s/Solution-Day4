using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day4
{
    internal class ExceptionHandling
    {
        static void Main()
        {
            int num = 0;
            try
            {
                Console.WriteLine("Enter No ");
                num = Byte.Parse(Console.ReadLine());
                int rem = num / 0;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Pl enter numbers only");
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Num is not in range 0 -255");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Den can not be 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(num);

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside finally");
            }
            Console.WriteLine("Bye");
        }
    }
}
