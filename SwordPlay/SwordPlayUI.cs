using System;
using Player.PlayerMethods;
using Player.PlayerTypes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player;
using User;
using Weapons;

namespace SwordPlay
{
    public class SwordPlayUI
    {
        FighterGenerator _fighters = new FighterGenerator();
        EquipMethods equip = new EquipMethods();
        UserFighter player1 = new UserFighter();
        UserFighter player2 = new UserFighter();
        UserFighter cpuFighter = new UserFighter();
        EquipMethods _equipMethod = new EquipMethods();
        public void Run()
        {
            MainMenu();
        }
        public void MainMenu()

        {
            //Create fighters for user to choose from
            SeedFighters();
            //pick one or two players
            Console.WriteLine("Welcome to sword play. A turn based fighting game!\n" +
                "\n" +
                "Press (1) for single player,\n" +
                "Press (2) to fight a friend. ");
            //Get the users choice
            int playerCount = int.Parse(Console.ReadLine());
            //Let player 1 pick their fighter if one player and select a random fighter for them to fight.
            if (playerCount == 1)
            {
                Console.Clear();
                SelectAFighter();
                SelectYourWeapon();
                SelectRandomFighter();
                Console.WriteLine($"You choose {player1.Fighter.Name}\n" +
                $"Prepare to fight your opponent {cpuFighter.Fighter.Name}.\n\n" +
                $"Press enter to start the fight...");
                Console.ReadKey();
                OnePlayerFight();
            }
            //if two player let both players select their fighters
            if (playerCount == 2)
            {
                Console.Clear();
                Console.WriteLine("Player 1 select your fighter: ");
                SelectAFighter();
                SelectYourWeapon();
                Console.Clear();
                Console.WriteLine("Player 2 select your fighter: ");
                SelectAFighter2();
                SelectYourWeapon2();
                Console.WriteLine($"Time for a fight between {player1.Fighter.Name} and {player2.Fighter.Name}!\n" +
                    $"May the best fighter win!");
                Console.WriteLine("Press enter to start the fight...");
                Console.ReadKey();
                TwoPlayerFight();
            }
        }
        public void OnePlayerFight()
        {
            var r = new Random();
            var coinFlip = r.Next(1, 3);
            Console.WriteLine(coinFlip);
            Console.ReadKey();
            Console.Clear();

            if (coinFlip == 1)
            {
                Console.WriteLine($"{player1.Fighter.Name} you will attack first!");
                while (player1.Fighter.Health > 0 && cpuFighter.Fighter.Health > 0)
                {
                    Player1AttackAndHeal();
                    AttackCpu();
                }
            }
            else if (coinFlip == 2)
            {
                Console.WriteLine($"{cpuFighter.Fighter.Name} you will attack first!");
                while (player1.Fighter.Health > 0 && cpuFighter.Fighter.Health > 0)
                {
                    AttackCpu();
                    Player1AttackAndHeal();
                }                
            }
            else
            {
                return;
            }
        }
        private void TwoPlayerFight()
        {
            var r = new Random();
            var coinFlip = r.Next(1, 2);
            var playerHealth = player1.Fighter.Health;
            var player2Health = player2.Fighter.Health;
            Console.Clear();
            if (coinFlip == 1)
            {
                Console.WriteLine($"{player1.Fighter.Name} you will attack first!");
                while (playerHealth > 0 || player2Health > 0)
                {
                                   
                }
            }
            if (coinFlip == 2)
            {
                Console.WriteLine($"{player2.Fighter.Name} you will attack first!");
                while (playerHealth > 0 || player2Health > 0)
                {

                }
            }
        }
        private IFighter SelectAFighter()
        {
            Console.WriteLine("Select your fighter by number:\n" +
                "1: Author the Warrior\n" +
                "2: Sly the Assassin\n" +
                "3: King the Mage\n" +
                "4: Westly the Archer");
            string fighterSelect = Console.ReadLine();
            switch (fighterSelect)
            {
                case "1":
                    player1.Fighter = _fighters.CreateWarrior();
                    return player1.Fighter;
                case "2":
                    player1.Fighter = _fighters.CreateAssassin();
                    return player1.Fighter;
                case "3":
                    player1.Fighter = _fighters.CreateMage();
                    return player1.Fighter;
                case "4":
                    player1.Fighter = _fighters.CreateArcher();
                    return player1.Fighter;
                default:
                    Console.WriteLine("Seems like you can't read. Goodbye!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return null;
            }
        }
        private IFighter SelectAFighter2()
        {
            Console.WriteLine("Select your fighter by number:\n" +
                "1: Author the Warrior\n" +
                "2: Sly the Assassin\n" +
                "3: King the Mage\n" +
                "4: Westly the Archer");
            string fighterSelect = Console.ReadLine();
            switch (fighterSelect)
            {
                case "1":
                    player2.Fighter = _fighters.CreateWarrior();
                    return player2.Fighter;
                case "2":
                    player2.Fighter = _fighters.CreateAssassin();
                    return player2.Fighter;
                case "3":
                    player2.Fighter = _fighters.CreateMage();
                    return player2.Fighter;
                case "4":
                    player2.Fighter = _fighters.CreateArcher();
                    return player2.Fighter;
                default:
                    Console.WriteLine("Seems like you can't read. Goodbye!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return null;
            }
        }
        private IFighter SelectRandomFighter()
        {
            Console.Clear();
            Random random = new Random();
            int randFighterInt = random.Next(1, 4);
            //pick a random IFighters from the list of Ifighters
            if (randFighterInt == 1)
            {
                cpuFighter.Fighter = _fighters.CreateWarrior();
                return cpuFighter.Fighter;
            }
            else if (randFighterInt == 2)
            {
                cpuFighter.Fighter = _fighters.CreateAssassin();
                return cpuFighter.Fighter;
            }
            else if (randFighterInt == 3)
            {
                cpuFighter.Fighter = _fighters.CreateMage();
                return cpuFighter.Fighter;
            }
            else if (randFighterInt == 4)
            {
                cpuFighter.Fighter = _fighters.CreateArcher();
                return cpuFighter.Fighter;
            }
            else
            {
                return null;
            }
        }
        private IFighter SelectYourWeapon()
        {
            Console.WriteLine("It's time to select a weapon. \n"
                + "Choose Wisely: \n"
                + "1. Sword \n"
                + "2. Dagger\n"
                + "3. Bow and Arrow\n"
                + "4. Staff ");
            string weaponSelect = Console.ReadLine();
            switch (weaponSelect)
            {
                case "1":
                    _equipMethod.EquipSword(player1.Fighter.Damage, player1.Fighter);
                    return player1.Fighter;

                case "2":
                    _equipMethod.EquipDagger(player1.Fighter.Damage, player1.Fighter);
                    return player1.Fighter;
                case "3":
                    _equipMethod.EquipBow(player1.Fighter.Damage, player1.Fighter);
                    return player1.Fighter;
                case "4":
                    _equipMethod.EquipStaff(player1.Fighter.Damage, player1.Fighter);
                    return player1.Fighter;
                default:
                    Console.WriteLine("Read and try again...\n" +
                        "\n" +
                        "Press any key to continue...");
                    return null;
            }
        }
        private IFighter SelectYourWeapon2()
        {
            Console.WriteLine("It's time to select a weapon. \n"
                + "Choose Wisely: \n"
                + "1. Sword \n"
                + "2. Dagger\n"
                + "3. Bow and Arrow\n"
                + "4. Staff ");
            string weaponSelect = Console.ReadLine();
            switch (weaponSelect)
            {
                case "1":
                    _equipMethod.EquipSword(player2.Fighter.Damage, player2.Fighter);
                    return player2.Fighter;

                case "2":
                    _equipMethod.EquipDagger(player2.Fighter.Damage, player2.Fighter);
                    return player2.Fighter;
                case "3":
                    _equipMethod.EquipBow(player2.Fighter.Damage, player2.Fighter);
                    return player2.Fighter;
                case "4":
                    _equipMethod.EquipStaff(player2.Fighter.Damage, player2.Fighter);
                    return player2.Fighter;
                default:
                    Console.WriteLine("Read and try again...\n" +
                        "\n" +
                        "Press any key to continue...");
                    return null;
            }
        }
        private List<IFighter> SeedFighters()
        {
            List<IFighter> fighters = new List<IFighter>();

            Warrior aurthor = _fighters.CreateWarrior();
            Assassin sly = _fighters.CreateAssassin();
            Mage king = _fighters.CreateMage();
            Archer westly = _fighters.CreateArcher();

            fighters.Add(aurthor);
            fighters.Add(sly);
            fighters.Add(king);
            fighters.Add(westly);
            return fighters;
        }
        private void Player1AttackAndHeal()
        {
            Console.WriteLine($"Player 1 ({player1.Fighter.Name}) would you like to attack your opponent or rest to gain health:\n" +
                "1. Attack \n" +
                "2. Rest \n");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {               
                Console.WriteLine(cpuFighter.Fighter.Health);
                int adjustedHealth = cpuFighter.Fighter.Health - player1.Fighter.Damage;
                cpuFighter.Fighter.Health = adjustedHealth;
                Console.WriteLine(cpuFighter.Fighter.Health);
            }
            else if(userInput == 2)
            {
                var halfOfHealth = player1.Fighter.Health / 2;
                Console.WriteLine(player1.Fighter.Health);
                if (player1.Fighter.Health < 50)
                {
                    int healedSomeHealth = player1.Fighter.Health + 20;
                    player1.Fighter.Health = healedSomeHealth;
                    Console.WriteLine(player1.Fighter.Health);
                }
                else
                {
                    Console.WriteLine("You were unable to heal yourself! Take more damage!");
                }
            }
            else
            {
                return;
            }
        }
        private void AttackCpu()
        {
            Console.WriteLine($"Computer ({cpuFighter.Fighter.Name}) you like to Attack your opponent or Rest to gain health:\n" +
                "1. Attack \n" +
                "2. Rest \n");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                 Console.WriteLine(player1.Fighter.Health);
                int adjustedHealth = player1.Fighter.Health - cpuFighter.Fighter.Damage;
                player1.Fighter.Health = adjustedHealth;
                Console.WriteLine(player1.Fighter.Health);
            }
            else if (userInput == 2)
            {                
                Console.WriteLine(cpuFighter.Fighter.Health);
                if (50 > cpuFighter.Fighter.Health)
                {
                    int healedSomeHealth = cpuFighter.Fighter.Health + 20;
                    cpuFighter.Fighter.Health = healedSomeHealth;
                    Console.WriteLine(cpuFighter.Fighter.Health);
                }
                else
                {
                    Console.WriteLine("You were unable to heal yourself! Take more damage!");
                }
            }
            else
            {
                return;
            }
        }
    }
}
