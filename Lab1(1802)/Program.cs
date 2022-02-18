using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1_1802_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> number = new List<string>() { "Dima", "Vasya", "Stas", "Oleg", "Semen", "Max" };
            ParameterizedThreadStart threadstart = new ParameterizedThreadStart(ThreadFunc);
            Thread thread1 = new Thread(threadstart);
            thread1.Start((object)number);

            Console.ReadKey();

        }

        static void ThreadFunc(object a)
        {
            foreach (var n in (List<string>)a)
            {
                Console.WriteLine(n.ToString());
            }

        }
    }
}
