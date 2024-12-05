using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Game
    {
        public void Start()
        {
            var sword = new Sword();
            var player = new Player(sword);

            Console.WriteLine("Добро пожаловать в игру!");
            Console.WriteLine("Выберите оружие: 1 - Меч, 2 - Лук, 3 - Топор, 4 - Миниган, 5 - Лазерная Пушка, 0 - Выход");

            while (true)
            {
                Console.Write("\nВаш выбор: ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("Вы вышли из игры. До встречи!");
                    break;
                }

                switch (input)
                {
                    case "1":
                        player.SetWeapon(new Sword());
                        break;
                    case "2":
                        player.SetWeapon(new Bow());
                        break;
                    case "3":
                        player.SetWeapon(new Axe());
                        break;
                    case "4":
                        player.SetWeapon(new Minigan());
                        break;
                    case "5":
                        player.SetWeapon(new LaserGun());
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        continue;
                }

                player.Attack();
            }
        }
    }
}
