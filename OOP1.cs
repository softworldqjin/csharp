using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class OOP1
    {   
        class Player
        {
            static public int counter = 1; // 오로지 1개만 존재, 모든 객체에서 동읾한 값
            public int id;
            public int hp;
            public int attack;

            public Player()
            {
                Console.WriteLine("Player 생성자 호출");
            }

            public Player(int hp)
            {
                this.hp = hp;
                Console.WriteLine("hp 생성자 호출");
            }
            public void Move()
            {
                Console.WriteLine("Player Move");
            }

            public void Attack()
            {
                Console.WriteLine("Player Attack");
            }
        }
        
        class Archer : Player
        {

        }

        class C_mage : Player
        {

        }
        // 객체 (OOP Object Oriented Programming)

        // 속성 hp, attack
        // 기능 Move, Attack, Die 

        // 절차지향
        // 함수가 순서에 종속적임
        // 프로그램이 비대해질수록 로직이 꼬이고, 함수가 엄청 많아진다
        // == 유지보수가 어렵다
        
        struct Mage
        {
            int hp;
            int attack;
        }

        // ref 참조
        class Knight : Player // 기본 접근제어자 private
        {
            
             public Knight() : base(100) // 이러면 Player 기본 생성자 호출되지 않고, 매개변수를 받는 생성자 호출됨
            {
                base.hp = 100;
                Console.WriteLine("Knight 생성자 호출");
            }
            
            public Knight(int hp) : this() // Knight(int hp) 호출하고, Knight() 호출
            {
                this.hp = hp;
                Console.WriteLine("(int 매개변수) Knight 생성자 호출");
            }

            public Knight(int hp, int attack)
            {
                this.hp = hp;
                this.attack = attack;
                Console.WriteLine("(int 매개변수, int 매개변수) Knight 생성자 호출");
            }
            public Knight Clone()
            {
                Knight knight = new Knight();
                knight.hp = hp;
                knight.attack = attack;
                return knight; // 참조(주소) 반환
            }
            
            public void Stun()
            {
                Console.WriteLine("스턴 발동");
            }
            

            

            static public Knight MakeKnight()
            {
                Knight knight = new Knight();
                knight.hp = 10;
                knight.attack = 20;

                return knight;
            }

            static public void Test() // Knight의 고유 함수,, 각 객체의 멤버를 접근한다는게 말이 안됨
            {
                counter++;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight(); // knight는 참조를 들고 있음. 
            //knight.hp = 100;
            //knight.attack = 10;

            Mage mage = new Mage(); // 모든 변수를 0으로 초기화

            Knight knight2 = knight.Clone();

            Knight knight3 = new Knight(50);

            Knight knight4 = new Knight(10, 20);

            Knight knight5 = Knight.MakeKnight(); // static 함수

            knight2.Move();
            knight2.Stun();
            
        }
    }
}
