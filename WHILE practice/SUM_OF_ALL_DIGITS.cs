﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_practice
{
    internal class SUM_OF_ALL_DIGITS
    {
        static void Main(string[] args)
        {
            int u, v, sum = 0;
            Console.WriteLine("enter the number");
            u = Convert.ToInt32(Console.ReadLine());

            while (u > 0)
            {
                v = u % 10;
                sum = sum + 1;
                u = u / 10;
            }
            Console.WriteLine(sum);
        }
    
    }
}
