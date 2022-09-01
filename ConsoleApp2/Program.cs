using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn en temperatur, et heltall");
            int grader = Convert.ToInt32(Console.ReadLine());
            
            if (grader < 0)
            {
                Console.WriteLine("minusgrader");
            }

            else
            {
                Console.WriteLine("plussgrader");
            }
        }
    }
}
