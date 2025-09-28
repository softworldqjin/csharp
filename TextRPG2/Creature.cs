﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum CreatureType
    {
        None,
        Player = 1,
        Monster = 2
    }

    internal class Creature
    {
        CreatureType type = CreatureType.None;

        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        protected int hp = 0;
        protected int attack = 0;

        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }

        public bool IsDead() { return hp <= 0; }

        public void OnDagmaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
    }
}
