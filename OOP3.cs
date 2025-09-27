using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class OOP3
    {
        class Player
        {
            protected int hp;
            protected int attack;

            public virtual void Move()
            {
                Console.WriteLine("Player 이동");
            }
        }

        // 오버로딩 : 함수 이름의 재사용 void Move() / void Move(int a)
        // 오버라이딩 : 다형성
        //             부모 클래스를 상속받는 자식 클래스에서의 함수 재정의
        class Knight : Player
        {
            public override void Move() // public sealed override void Move() 다음 상속받는 클래스에서 override 불가
            {
                Console.WriteLine("Knight 이동");
            }
        }

        class KingKnight : Knight
        {
            public override void Move()
            {
                base.Move(); // virtual로 선언된 함수 호출
                Console.WriteLine("KingKnight 이동"); // 부모의 부모 클래스에서 virtual 로 선언 시에도 override 가능
            }
        }

        class Mage : Player
        {
            public int mp;

            public override void Move()
            {
                Console.WriteLine("Mage 이동");
            }
        }

        static void EnterGame(Player player)
        {
            player.Move();  // 오버라이딩을 하면 해당 클래스의 함수 호출
                            // 오버라이딩을 하지않으면 부모 클래스의 함수 호출

            Mage mage = (player as Mage); // Mage형으로 변환된 참조(주소)를 반환,, 아니면 null(아무데도 참조X) 반환
            
            if (mage != null)
            {
                mage.mp = 10;
            }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            Player player = new Mage();
            Mage mage2 = (Mage)player;  // 만약 player가 Knight 타입이면 ERROR

                                        // 이것을 안전하게 형변환하기 위해 as를 쓰자.
            
            EnterGame(knight);
            EnterGame(mage);

            Console.WriteLine(mage.mp);
            
        }
    }
}
