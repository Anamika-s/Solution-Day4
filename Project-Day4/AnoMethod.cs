using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day4
{
    delegate int Del (int x, int y);
    internal class AnoMethod
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Product(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            Del del = new Del(Add);
            Console.WriteLine(del(10, 2));
            del = new Del(Sub);
            Console.WriteLine(del(10, 2));
            del = new Del(Product);
            Console.WriteLine(del(10, 2));
            
            //Del d1 = new Del(Product);
            //d1 += new Del(Add);
            //d1+= new Del(Sub);

            //Console.WriteLine(d1(10,90));
        }

    }
}
