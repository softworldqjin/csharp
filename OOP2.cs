using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class OOP2
    {
        class Knight
        {
            protected int hp; // 외부에서 사용할 수 없지만, 상속받은 클래스에서 사용가능
        }
        
        class SuperKnight : Knight
        {
            public SuperKnight()
            {
                hp = 10;
            }
        }
    }
}
