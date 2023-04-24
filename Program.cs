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
            Console.WriteLine("Enter the number to check even or odd: "); 
            int num=int.Parse(Console.ReadLine());
            if(num%2==0 )
            {
                Console.WriteLine(" Number {0} Is Even: ",num);
            }
            else
            {
                Console.WriteLine(" Number {0} Is Odd: ",num);
                Console.ReadLine();
            }
        }
    }
}
