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
            Console.WriteLine("Enter the marks of mathematics");
            int math = int.Parse(Console.ReadLine());          //>=65
            Console.WriteLine("Enter the marks of Physics");
            int Physics = int.Parse(Console.ReadLine());       // >=50
            Console.WriteLine("Enter the marks of Chemistry");
            int Chem = int.Parse(Console.ReadLine());         //>=65          


            if(math+Physics+Chem >= 180)
            {
                Console.WriteLine("Candidate is eligible for Admission");
            }
            else if(( math + Chem) >= 140)
            {
                Console.WriteLine("Candidate is eligible for Admission");
            }
            else if ((math + Physics) >= 140)
            {
                Console.WriteLine("Candidate is eligible for Admission");

            }
            else
            {
                Console.WriteLine("Candidate is not eligible for Admission");

            }
            Console.ReadLine();
        }
    }
}
