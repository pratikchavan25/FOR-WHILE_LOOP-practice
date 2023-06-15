using System.Diagnostics.CodeAnalysis;

namespace WHILE_practice
{
    internal class FORLOOP04
    {
        // 6.	 Write a program to find sum of all even numbers between 1 to n. 
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n1 = Convert.ToInt32 (Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= n1; i += 2)

                sum = sum + i;
                 
            {
                Console.WriteLine(sum);
            }
        

        }
    }
}
