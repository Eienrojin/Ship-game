//TODO
//Дописать инвентарь у игрока

namespace Boat_Battle
{
    class Program
    {
        static void Main()
        {
            Player player;

            player = GetStart();

            Fight(player.OwnBoat, CreateEnemy());
        }

        static Player GetStart()
        {
            FirstBoat firstBoat = new("Jabodav", 400, 450);

            string name;
            int answer;

            Console.WriteLine("Eh, were are you going captain? You're looking sleppy." +
                "\nWoah, you're looking so sick" +
                "\nDidn't you lost your memory?" +
                "\nSay your name, captain");

            name = Console.ReadLine();

            if (name == "")
            {
                name = CreateName();
            }

            Console.WriteLine("We're not so far from the city" +
                "\nEnemy ship is near! Get ready to shoot!");

            return new Player(name, firstBoat);
        }

        static string CreateName()
        {
            int answer = -1;
            string name;
            string[] names = { "Joe", "Murasa", "Jack", "Torrent", "Xatab" };
            bool safe = true;
            bool choice = false;

            while (true)
            {
                Console.WriteLine("Wow, you don't remember the name." +
                                "\nDo you want to choice a new name?" +
                                "\n1. Yes, choice a new name (choice a name from list)" +
                                "\n2. No, I remember the name");

                answer = InitAndCheckAnsw();

                switch (answer)
                {
                    default:
                        Console.WriteLine("I didn't understood, tell me one more time");
                        break;
                    case 1:
                        Console.WriteLine("Choice one name" +
                        "\n1. Joe" +
                        "\n2. Murasa" +
                        "\n3. Jack" +
                        "\n4. Torrent" +
                        "\n5. Xatab");

                        answer = InitAndCheckAnsw();
                        answer--;

                        int length = names.Length - 1;

                        if (answer <= length && answer >= 0)
                        {
                            return names[answer];
                        }
                        else
                        {
                            Console.WriteLine("???");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tell a new name...");

                        name = Console.ReadLine();

                        if(name != "")
                        {
                            return name;
                        }
                        else
                        {
                            Console.WriteLine("Captain? Can you speak?");
                        }
                        break;
                }
            }
        }

        static void Fight(Boat player, Boat enemy)
        {
            bool choice = false;
            bool safeChoice = true;
            int answer = -1;

            while (enemy.HP > 0)
            {
                while (!choice)
                {
                    Console.WriteLine(player);
                    Console.WriteLine(enemy);
                    Console.Clear();

                    Console.WriteLine("You've been attacked");
                    Console.WriteLine("\n1. Shoot" +
                        "\n2. Go to the ship's hold");

                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("What");
                        safeChoice = false;
                    }

                    if (safeChoice || answer != 0)
                    {
                        break;
                    }
                }

                if (safeChoice)
                {
                    switch (answer)
                    {
                        default:
                            Console.WriteLine("...");
                            break;
                        case 1:
                            if (player.UsingWeapon is not null)
                            {
                                enemy.GetDamage(player.UsingWeapon.Shoot());
                            }
                            else
                            {
                                Console.WriteLine("You haven't any weapons!");
                            }

                            choice = true;
                            break;
                        case 2:
                            //Вставить показ инвентаря
                            throw new NotImplementedException("Нет показа инвентаря");
                            break;
                    }
                }


                player.GetDamage(enemy.UsingWeapon.Shoot());
            }
        }

        static Boat CreateEnemy()
        {
            Random random = new();

            RandomBoat boat = new("", random.Next(300, 800), 800);

            boat.UsingWeapon = new RandomWeapon("", random.Next(25, 300), random.Next(200, 300), 30);

            return boat;
        }

        static void Encounter(Boat playerBoat)
        {
            Random random = new();

            //Бросание кубика
            int randomNum = random.Next(1, 12);

            if (randomNum % 2 == 0)
            {
                Fight(playerBoat, CreateEnemy());
            }
            if(randomNum == 5)
            {
                //Механика торговли с торговым судном
                //Или его грабеж
                throw new NotImplementedException("Нет механики торговли с чужим судном");
            }
        }

        public static int InitAndCheckAnsw()
        {
            bool safe;
            int answ = 0;

            while (true)
            {
                safe = true;

                try
                {
                    answ = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("What");
                    safe = false;
                }

                if (safe) { break; }
            }

            return answ;
        }
    }

}