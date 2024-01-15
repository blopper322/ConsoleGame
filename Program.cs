using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет странник!");
        Console.Write("Как тебя звать ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nВаше имя {playerName}!");

        int playerHealth = 100;
        int playerAttack = 20;
        int medkitHeal = 10;
        int medkits = 1;

        Console.WriteLine($"Вам был выдан пистолет и 10 пуль ({playerAttack}), а также средняя аптечка ({medkitHeal}hp).\nУ вас {playerHealth}hp.");

        string enemyName = "Бандит";
        int enemyHealth = 40;
        int enemyAttack = 10;

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"\n{playerName} встречает врага {enemyName} ({enemyHealth}hp), у врага в подсумке пистолет ({enemyAttack})");
            Console.WriteLine("Что вы будете делать?");
            Console.WriteLine("1. Убить его\n2. Пропустить ход\n3. Использовать аптечку");
            Console.Write(">");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"\n{playerName} выстрелил в врага {enemyName}");
                    enemyHealth -= playerAttack;
                    break;
                case "2":
                    Console.WriteLine($"\n{playerName} пропускает ход");
                    break;
                case "3":
                    if (medkits > 0)
                    {
                        Console.WriteLine($"\n{playerName} использовал аптечку");
                        playerHealth = Math.Min(playerHealth + medkitHeal, 100);
                        medkits--;
                    }
                    else
                    {
                        Console.WriteLine($"\nУ {playerName} нет аптечек!");
                    }
                    break;
                default:
                    Console.WriteLine("\nНеверный выбор. Попробуйте снова.");
                    continue;
            }

            if (enemyHealth > 0)
            {
                Console.WriteLine($"{enemyName} выстрелил в вас!");
                playerHealth -= enemyAttack;
            }

            Console.WriteLine($"У противника {enemyHealth}hp, у вас {playerHealth}hp");
        }

        if (playerHealth > 0)
        {
            Console.WriteLine($"\n{playerName} победил!");
        }
        else
        {
            Console.WriteLine($"\n{playerName} был убит(((");
        }
    }
}
