using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 100;

            while (i <= n)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                    i++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    i++;
                }
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                    i++;
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine("Uneven " + i);
                }
                else
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
    }
}
