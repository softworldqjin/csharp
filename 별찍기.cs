using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
        }
    }
}
