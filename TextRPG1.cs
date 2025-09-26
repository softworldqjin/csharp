using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp
{

    internal class TextRPG1
    {
        enum Job
        {
            None,
            knight,
            Archer,
            Mage
        }

        enum Monster
        {
            None,
            slime,
            ock,
            skeleton
        }
        struct Player
        {
            public int hp;
            public int attack;
        }
        
        struct MonsterOp
        {
            public int hp;
            public int attack;
        }
        static Job ChoiceJob()
        {
            Job choice = Job.None;
            string input;
            while (true)
            {
                Console.WriteLine("직업을 선택하세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        choice = Job.knight;
                        break;
                    case "2":
                        choice = Job.Archer;
                        break;
                    case "3":
                        choice = Job.Mage;
                        break;
                    default:
                        break;
                }

                if (choice != Job.None)
                    break;
            }
            return choice;
        }
        
        static void CreatePlayer(Job choice, out Player player)
        {
            switch (choice)
            {
                case Job.knight:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                case Job.Archer:
                    player.hp = 40;
                    player.attack = 16;
                    break;
                case Job.Mage:
                    player.hp = 30;
                    player.attack = 17;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;  
            }
        }

        static void Fight(ref Player player, ref MonsterOp monster)
        {
            while (true)
            {
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("몬스터 처치 완료, 승리");
                    Console.WriteLine($"남은 체력: {player.hp}");
                    break;
                }

                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("플레이어 죽음, 패배");
                    break;
                }
            }
        }
        static void MakeMonster(out MonsterOp monster)
        {
            Random rand = new Random();
            int randomMonster = rand.Next(1, 4);

            switch (randomMonster)
            {
                case (int)Monster.slime:
                    Console.WriteLine("슬라임 스폰됨");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                
                case (int)Monster.ock:
                    Console.WriteLine("오크 스폰됨");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                
                case (int)Monster.skeleton:
                    Console.WriteLine("스켈레톤 스폰됨");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default :
                    // default에서도 monster 구조체 변수 할당해야됨
                    monster.hp = 0;
                    monster.attack = 0;
                    break;

            }

        }
        static void EnterField(ref Player player)
        {
            Console.WriteLine("필드에 접속했습니다.");

            // 몬스터 생성
            MonsterOp monster;
            MakeMonster(out monster);

            // 1 전투 시작
            Console.WriteLine("[1] 전투한다");
            // 2 도망
            Console.WriteLine("[2] 도망친다");
            
            string input = Console.ReadLine();
            if (input == "1")
            {
                Fight(ref player, ref monster);
            }
            else if (input == "2")
            {
                Random random = new Random();   
                int runAble = random.Next(0, 101);

                if (runAble <= 33)
                {
                    Console.WriteLine("마을 도망 성공");
                    return;
                }
                else
                {
                    Fight(ref player, ref monster);
                }
            }
            
        }
        static void EnterGame(ref Player player)
        {   
            while (true)
            {
                // 마을에 접속
                Console.WriteLine("마을에 접속했습니다.");
                // 1 필드로 가기
                Console.WriteLine("[1] 필드 이동");
                // 2 로비로 가기
                Console.WriteLine("[2] 로비 이동");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    EnterField(ref player);
                }
                else if (input == "2")
                {
                    return;
                }
            }
            
        }
        static int Main(string[] args)
        {
            while (true)
            {
                Job choice = ChoiceJob();
                if (choice != Job.None)
                {
                    Player player;

                    CreatePlayer(choice, out player);
                    // knight 100/100 archer 80/110 mage 60/120

                    Console.WriteLine($"hp: {player.hp}, attack: {player.attack}");

                    EnterGame(ref player);
                  
                }
            }

            return 0;
        }
    }
}
