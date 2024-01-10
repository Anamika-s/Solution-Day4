using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day4
{
    internal class Test
    {
        public void Get1()
        {
            Console.WriteLine("Get1");
        }
        public string Table(int num)
        {
            StringBuilder sb = new StringBuilder();
            //string str = "";
            for (int i = 1; i <= 10; i++)
            {
                //str+= $"{num} * {i} = {num * i}";
                sb.AppendLine($"{num} * {i} = {num * i}");
            }
            return sb.ToString();
        }
    }

    static class ExtendedTest
    {
        public static void Get2(this Test test, string name)
        {
            Console.WriteLine("Hello " + name);
            int num = 10;
            Console.WriteLine(num.IsEven(num));
        }

    }


    static class ExtendedIntClass
    {
        public static bool IsEven(this int x, int num)
        {

            {
                return num % 2 == 0 ? true : false;
            }
        }

    }
}