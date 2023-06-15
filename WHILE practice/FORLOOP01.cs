using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_practice
{
    internal class FORLOOP01
    {
        // 1.	 Write a program to print even numbers from 121 to 229 using for loop.
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }


        }
    }
}
