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
            Console.WriteLine(" Insert the number to find table");
            int num=int.Parse(Console.ReadLine());
            int table = 1;
            for(int i=2; i<num; i++)
            {
                Console.Write("table of {0} is: ",i);
                for(int j=1;j<=10; j++)
                {
                    table = i * j;
                    Console.Write(table+" ");
                }
                Console.WriteLine();              
            }
            Console.ReadLine();

            //int sqr = 1, i;
            //Console.WriteLine("insert the number to find sqr");
            //int num=int.Parse(Console.ReadLine());
            //for(i=0;i<num; i++)
            //{
            //    sqr = sqr * 2;
            //    Console.WriteLine(sqr);
            //}
        }
    }
}
