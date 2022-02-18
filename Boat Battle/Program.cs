namespace Boat_Battle
{
    class Program
    {
        static void Main()
        {
            Player player;

            GetStart(player);
        }

        static void GetStart(Player player)
        {
            string name;

            Console.WriteLine("Eh, were are you going captain? You're looking sleppy." +
                "\nWoah, you're looking so sick" +
                "\nDidn't you lost your memory?" +
                "\nSay your name, captain");

            name = Console.ReadLine();

            player = new Player(name, );

            Console.WriteLine("We're not so far from the city");
        }

        static void Fight(Boat player, Boat enemy)
        {
            bool choice = false;
            bool unsafeAnsw = false;
            int answer = -1;

            while (enemy.HP > 0)
            {
                while (unsafeAnsw)
                {

                    Console.Clear();

                    Console.WriteLine("You've been attacked");
                    Console.WriteLine("\n1. Shoot" +
                        "\n2. Go to the ship's hold");

                    try
                    {
                        answer = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("What");
                        unsafeAnsw = true;
                    }

                    if (!unsafeAnsw)
                    {
                        break;
                    }
                }

                while (!choice)
                {
                    switch (answer)
                    {
                        default:
                            Console.WriteLine("...");
                            break;
                        case 1:
                            enemy.GetDamage(player.UsingWeapon.Shoot());
                            choice = true;
                            break;
                        case 2:
                            //Вставить показ инвентаря
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

        static void Encounter(Boat player)
        {
            Random random = new();

            //Бросание кубика
            int randomNum = random.Next(1, 6);

            if (randomNum % 2 == 0)
            {
                Fight(player, CreateEnemy());
            }
            else
            {
                Console.WriteLine("There is so still and no any enemy boat");
            }
        }
    }

}