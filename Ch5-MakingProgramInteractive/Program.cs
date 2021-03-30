using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch5_MakingProgramInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Example 1 (WriteLine)-------------");
            Console.WriteLine("Hello");
            Console.WriteLine("How are you");
            //Console.ReadLine();

            Console.WriteLine("---------------Example 2(Write)-------------");
            Console.Write("Hello");
            Console.Write("How are you");
            //Console.Read();

            Console.WriteLine("\n---------------Example 3 (Alternate method of including using static system.console)-------------");
            WriteLine("Hello");
            Write("How are you");
            Console.ReadLine();
        }
    }
}