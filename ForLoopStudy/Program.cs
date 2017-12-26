using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            for (;;) {
                n++;
                sum += n;
                if (n > 2) break;
            }
            Console.WriteLine(sum);
        }
    }
}
