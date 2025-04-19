using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0) { Console.WriteLine(1); }
            else if (x < 0 && y > 0) { Console.WriteLine(2); }
            else if (x < 0 && y < 0) { Console.WriteLine(3); }
            else if (x > 0 && y < 0) { Console.WriteLine(4); }
        }
    }
}