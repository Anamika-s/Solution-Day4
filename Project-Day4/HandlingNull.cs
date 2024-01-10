using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day4
{
    internal class HandlingNull
    {
        static void Main()
        {
            string name = null;
            int? num = 5;
            if(num.HasValue)
            {
                Console.WriteLine(num.Value.ToString());
            }
            else
            Console.WriteLine("Num contains null");
            string name1 = "";
            string name2 = string.Empty;

            string name3 = null;
            if(string.IsNullOrEmpty(name1))
            {


            }


        }
    }
}
