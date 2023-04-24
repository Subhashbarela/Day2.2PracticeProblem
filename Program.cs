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
            int Ram = 0;
            int Sham = 1;
            Random random= new Random();
            for(int i=1; i<=20; i++)
            {
               int check= random.Next()%2;
              
                if(check == 0)
                {
                    Ram++;
                }
                else
                {
                    Sham++;
                }
            }
            if(Ram > Sham)
            {
                Console.WriteLine("ram pt is {0} and sham pt {1} so Ram is winner: ",Ram,Sham);
            }
            else
            {
                Console.WriteLine("sham pt is {0} and ram pt {1} so Sham is winner: " , Sham,Ram);

            }
        }
    }
}
