using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_practice
{
    internal class FORLOOP06
    {
        // 7.	 Write a program to find sum of all odd numbers between 1 to n ?
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int j = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= j; i += 2)

                sum = sum + i;
                
            {
                Console.WriteLine(sum);
            }
        }
    }
}
