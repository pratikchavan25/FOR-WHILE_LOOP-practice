﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_practice
{
    internal class FACTORIAL
    {
        static void Main(string[] args)
        {
            int n, fact = 1;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
        }
    }
}
