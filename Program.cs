using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the number to find factorial");
            int num=int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1; i<=num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("factorial of given number is: "+fact);
        }
    }
}
