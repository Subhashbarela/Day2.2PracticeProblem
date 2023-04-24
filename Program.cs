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
            Console.WriteLine("Pleasr insert the number to find sum of square");
            int num=int.Parse(Console.ReadLine());
            int sum = 0;
            int sqr = 0;
            for(int i=1; i<=num; i++)
            {
                sqr= i * i;
                Console.WriteLine(sqr);
                sum += sqr;
            }
            Console.WriteLine("Total sum of given Square is: "+sum);

            Console.ReadLine();
        }
    }
}
