using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day
{
    delegate int Del(int x, int y);
    internal class Ano1
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        // this is to ctreate Anom method , that uses delegate
        static Del d2 = delegate (int x, int y)
        {
            return x + y;
        };
        // short way to write anon method , Lambda Expression

        static Del d3 = (x, y) => { return x - y; };
         
        static void Main()
        {
            Del d1 = new Del(Add);
            Console.WriteLine(d2(10,89));     
        }
    }
}
