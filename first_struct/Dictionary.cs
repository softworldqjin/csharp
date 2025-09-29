using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Monster
    {
        public int id;
        public Monster(int id)
        {
            this.id = id;
        }
    }
    class Dictionary
    {      
        static void Main(string[] args)
        {
            // Hashtable
            // 아주 큰 박스 [ ........]
            // 박스 여러개를 쪼개 놓는다. [1~10] [11~20] [ ] [ ] [ ] ... 1천개
            // 777번째 공?
            // 메모리 손해
            // 메모리를 내주고, 성능을 취한다.



            // Key 로 Value 찾기
            // Dictionary
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for (int i = 0; i < 10000; ++i)
            {
                dic.Add(i, new Monster(i));
            }

            Monster monster1;
            bool found = dic.TryGetValue(20000, out monster1);

            dic.Remove(20); // key 20 삭제
            dic.Clear(); // 모두 삭제

            //Monster monster1 = dic[5000];

            //dic.Add(1, new Monster(1)); // Add(int key, Monster value)

            //dic[5] = new Monster(5);
        }
    }
}
