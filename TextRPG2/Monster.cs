using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum MonsterType
    {
        None,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }
    class Monster : Creature
    {
        protected MonsterType type;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType GetMonsterType() { return type; }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            Console.WriteLine("슬라임이 생성되었습니다.");
            SetInfo(10, 5);
        }

    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            Console.WriteLine("오크가 생성되었습니다.");
            SetInfo(15, 7);
        }
    }

    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            Console.WriteLine("스켈레톤이 생성되었습니다.");
            SetInfo(12, 8);
        }
    }
}

