using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Factorial
    {
        static int Factori(int x)
        {
            //int result = 1;
            //for (int i = x; i > 0; --i)
            //{
            //    result *= i;
            //}
            //return result;

            if (x == 1) return 1;
            return x * Factori(x - 1);
        }

          static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factori({num}) = {Factori(num)}");
        }
    }
}
