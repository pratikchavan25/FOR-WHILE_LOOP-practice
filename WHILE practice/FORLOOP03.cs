using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_practice
{
    internal class FORLOOP03
    {
        // 5.	 Write a program to print all alphabets from a to z using for loop .
        static void Main(string[] args)
        {
            for ( char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
