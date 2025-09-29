using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Map
    {
        int[,] tiles =
        {
            {1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 1 },
            {1, 0, 0, 0, 1 },
            {1, 0, 0, 0, 1 },
            {1, 1, 1, 1, 1 }
        };

        public void Render()
        {                                                   // -> 행 가로
                                                            // |  열 세로
            for (int y = 0; y < tiles.GetLength(1); ++y) // int[0,1] 0행 1열
            {
                for (int x = 0; x < tiles.GetLength(0); ++x)
                {
                    if (tiles[x, y] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
        }
    }

    class array2
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            int[,] arr1 = new int[2,3] { { 1, 2, 3 }, { 1, 2, 3 } };

            arr[0, 0] = 1;

            Map map1 = new Map();
            map1.Render();
        }
    }
}
