using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WHILE_practice
{
    internal class FORLOOP07
    {
        // 1. Find if given number is prime or not?
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 1; i++)



                if (a % 2 == 0)
                {
                    Console.WriteLine("its  not Prime Number");
                }
                else
                {
                    Console.WriteLine("its a Prime Number");
                }

        }
    }
}

