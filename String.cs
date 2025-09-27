using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class String
    {
        static void Main(string[] args)
        {
            string name = "Harry Portter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf("z");

            // 2. 변형
            name = name + " Junior";
            string lowerName = name.ToLower();
            string upperName = name.ToUpper();
            string newName = name.Replace('H', 'M');

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string subName = name.Substring(5);


        }
    }
}
