using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    class Game
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null;
        private Monster monster = null;
        Random random = new Random();
        public void Process()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine();
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine();
            Console.WriteLine("[1] 필드 이동");
            Console.WriteLine("[2] 로비 이동");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다.");
            Console.WriteLine();
            Console.WriteLine("[1] 싸우기");
            Console.WriteLine("[2] 도망치기(일정 확률)");

            CreateRandomMonster();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
            
        }

        private void TryEscape()
        {
            int randValue = random.Next(0, 100);
            if (randValue <= 33)
            {
                mode = GameMode.Town;
                Console.WriteLine("마을로 도망치기 성공");
            }
            else
            {
                ProcessFight();
            }
        }
        private void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDagmaged(damage);
                if (monster.IsDead())
                { 
                    Console.WriteLine("플레이어가 승리 했습니다.");
                    Console.WriteLine($"남은 체력 : {player.GetHp()}");
                    break;
                }

                damage = monster.GetAttack();
                player.OnDagmaged(damage);
                if (player.IsDead())
                {
                    Console.WriteLine("플레이어가 사망 했습니다.");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }
        private void CreateRandomMonster()
        {
            int randValue = random.Next(0, 3);
            switch (randValue)
            {
                case 0:
                    monster = new Slime();
                    break;
                case 1:
                    monster = new Orc();
                    break;
                case 2:
                    monster = new Skeleton();
                    break;
            }
        }

    }
}
