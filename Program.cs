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
            Console.WriteLine("Please insert the number to find sum");
            int num=int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
           while(temp > 0)
            {
                sum += temp;
                temp--;
            }
            Console.WriteLine("sum of {0} natural number is {1}",num,sum);
            Console.ReadLine();
        }
    }
}
