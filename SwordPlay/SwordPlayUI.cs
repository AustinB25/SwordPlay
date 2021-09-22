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
        EquipMethods _equip = new EquipMethods();
        UserFighter _player = new UserFighter();
        UserFighter _player2 = new UserFighter();
        UserFighter _cpuFighter = new UserFighter();
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
                Console.WriteLine($"You choose {_player.Fighter.Name}\n" +
                $"Prepare to fight your opponent {_cpuFighter.Fighter.Name}.");
                Console.ReadLine();
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
                SelectYourWeapon();
                Console.WriteLine($"Time for a fight between {_player.Fighter.Name} and {_player2.Fighter.Name}!\n" +
                    $"May the best fighter win!");
                Console.WriteLine("Press enter to start the fight...");
                Console.ReadKey();
                
            }  
        }
        public IFighter SelectAFighter()
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
                    _player.Fighter = _fighters.CreateWarrior();
                    return _player.Fighter;
                case "2":
                    _player.Fighter = _fighters.CreateAssassin();
                    return _player.Fighter;
                case "3":
                    _player.Fighter = _fighters.CreateMage();
                    return _player.Fighter;
                case "4":
                    _player.Fighter = _fighters.CreateArcher();
                    return _player.Fighter;
                default:
                    Console.WriteLine("Seems like you can't read. Goodbye!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return null;
            }
        }
        public IFighter SelectAFighter2()
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
                    _player2.Fighter = _fighters.CreateWarrior();
                    return _player2.Fighter;
                case "2":
                    _player2.Fighter = _fighters.CreateAssassin();
                    return _player2.Fighter;
                case "3":
                    _player2.Fighter = _fighters.CreateMage();
                    return _player2.Fighter;
                case "4":
                    _player2.Fighter = _fighters.CreateArcher();
                    return _player2.Fighter;
                default:
                    Console.WriteLine("Seems like you can't read. Goodbye!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return null;
            }
        }
        public IFighter SelectRandomFighter()
        {
            Console.Clear();
            Random random = new Random();
            int randFighterInt = random.Next(1, 4);           
            //pick a random IFighters from the list of Ifighters
            if (randFighterInt == 1)
            {
                _cpuFighter.Fighter = _fighters.CreateWarrior();
                return _cpuFighter.Fighter;
            }
            else if (randFighterInt == 2)
            {
                _cpuFighter.Fighter = _fighters.CreateAssassin();
                return _cpuFighter.Fighter;
            }
            else if (randFighterInt == 3)
            {
                _cpuFighter.Fighter = _fighters.CreateMage();
                return _cpuFighter.Fighter;
            }
            else if (randFighterInt == 4)
            {
                _cpuFighter.Fighter = _fighters.CreateArcher();
                return _cpuFighter.Fighter;
            }
            else
            {
                return null;
            }
        }        
        public IFighter SelectYourWeapon()
        {
            Console.WriteLine("It's time to select a weapon. \n"
                + "Choose Wisely: \n"
                + "1. Sword \n"
                + "2. Dagger\n"
                + "3. Bow and Arrow\n"
                + "4. Staff ");
           string weaponSelect =  Console.ReadLine();
            switch (weaponSelect)
            {
                case "1":
                    _equipMethod.EquipSword(_player.Fighter.Damage, _player.Fighter);
                    return _player.Fighter;
                    
                case"2":
                    _equipMethod.EquipDagger(_player.Fighter.Damage, _player.Fighter);
                    return _player.Fighter;
                case "3":
                    _equipMethod.EquipBow(_player.Fighter.Damage, _player.Fighter);
                    return _player.Fighter;
                case "4":
                    _equipMethod.EquipStaff(_player.Fighter.Damage, _player.Fighter);
                    return _player.Fighter;
                default:
                    Console.WriteLine("Read and try again...\n" +
                        "\n" +
                        "Press any key to continue...");
                    return null;                   
            }
        }
        public List<IFighter> SeedFighters()
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
}
}
