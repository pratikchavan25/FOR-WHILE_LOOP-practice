using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_practice
{
    // 4. Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by user ?
    internal class FIBONAACCI
    {
        static void Main(string[] args)
        {
            int n, first, second, third = 0;
            n = Convert.ToInt32(Console.ReadLine());

            first = 0;
            second = 1;

            Console.WriteLine(first+"\n"+second);

            for (int i = 0; i <n; i++)
            {
                third = first + second;
                Console.WriteLine(third);

                first = second;
                second = third;
            }

        }
    }
}
