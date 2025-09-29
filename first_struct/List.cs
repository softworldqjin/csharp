using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class List
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr[0] = 1;

            //List 동적 배열 [1 2 3] -> [1 2 3 1]
            List<int> list = new List<int>();
            for (int i = 0; i < 5; ++i)
            {
                list.Add(i);
            }

            // 삽입
            list.Insert(2, 999);

            // 삭제
            bool success = list.Remove(2);  // 2 지우기, 2가 여러 개 있다면, 첫 번째 2만 삭제
            list.RemoveAt(0);               // 0번째 인덱스 지우기


            // 전체삭제
            list.Clear();

            for (int i = 0; i < list.Count; ++i)
                Console.WriteLine(list[i]);

            
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
