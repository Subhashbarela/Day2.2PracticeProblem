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
            Console.WriteLine("Please insert number One");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert number Two");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert number Three");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1>num3)
            {
                Console.WriteLine("num1 is greater ");
            }
            else if(num2> num1 && num2>num3)
            {
                Console.WriteLine("numm2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
           
        }
    }
}
