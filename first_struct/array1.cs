using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class array1
    {
        static int GetHighestScore(int[] scores)
        {
            //int _hight = scores[0];
            //for (int i = 1; i < scores.Length; ++i)
            //{
            //    if (scores[i] > _hight)
            //    {
            //        _hight = scores[i];
            //    }
            //}
            int maxValue = 0;
            foreach (int score in scores)
            {
                if (score > maxValue) maxValue = score;
            }

            return 0;
        }

        static int GetAverageScores(int[] scores)
        {
            int sum = 0;
            int average = 0;

            foreach(int score in scores)
            {
                sum += score;
            }

            average = sum / scores.Length;
            return average;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; ++i)
            {
                if (scores[i] == value)
                {
                    return i;
                }    
            }
            return -1;
        }

        static void Sort(int[] scores)
        {
            int temp = 0;
            
            
            while (true)
            {
                int count = 0;
                for (int i = 0; i < scores.Length - 1; i++)
                {
                    if (scores[i] > scores[i + 1])
                    {
                        temp = scores[i];
                        scores[i] = scores[i + 1];
                        scores[i + 1] = temp;
                        ++count;
                    }
                }
                if (count == 0)
                {
                    break;
                }
            }
            
        }


        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            int high = GetHighestScore(scores);
            int average = GetAverageScores(scores);
            int index = GetIndexOf(scores, 10);
            Sort(scores);

            foreach (int i in scores)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("ww");

        }
    }
}
