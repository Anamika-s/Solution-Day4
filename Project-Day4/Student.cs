using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day4
{
    internal class Student
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Rn");
                byte rn = Byte.Parse(Console.ReadLine());
                if (rn < 1 || rn > 100)
                    throw new UserDefinedException("Rn range is 1 tp 100");
                string name;
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                if (name.Length < 10)
                    throw new UserDefinedException("Min 10 chars needed");
            }
            catch(UserDefinedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
