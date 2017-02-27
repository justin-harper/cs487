/*
*   Justin Harper
*   WSUID: 10696738
*   CS 487 Midterm
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
   public class Demo
    {
        ZombieFactory zf;
        
        public Demo()
        {
            zf = new ZombieFactory();
        }

        public void DoDemo()
        {
            while (true)
            {
                int c = DisplayMenu();
                switch (c)
                {
                    case 1: CreateZombie(); break;
                    case 2: PlayGame(); break;
                    case 3: Environment.Exit(0); break;                        
                }
                Console.WriteLine(zf.SpawnedZombies());
            }
        }

        //private void PlayGame()
        //{
        //    zf.ShootPeaShooter(25);
        //}

        private void PlayGame()
        {
            int Damage = GetDamage();
            zf.ShootPeaShooter(Damage);
        }

        private void CreateZombie()
        {
            int c = DisplaySpawnMenu();

            switch(c)
            {
                case 1: zf.SpawnRegularZombie();     break;
                case 2: zf.SpawnConeZombie();        break;
                case 3: zf.SpawnBucketZombie();      break;
                case 4: zf.SpawnScreenDoorZombie();  break;
            }
        }

        int DisplayMenu()
        {
            int choice = -1;

            while (choice == -1)
            {
                Console.WriteLine("1. Create Zombie?");
                Console.WriteLine("2. Demo game play?");
                Console.WriteLine("3. Exit");
                int.TryParse(Console.ReadLine(), out choice);
            }
            return choice;
        }

        int DisplaySpawnMenu()
        {
            int choice = -1;

            while(choice == -1)
            {
                Console.WriteLine("Which kind?");
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Cone");
                Console.WriteLine("3. Bucket");
                Console.WriteLine("4. ScreenDoor");
                int.TryParse(Console.ReadLine(), out choice);
            }

            return choice;                
        }

        int GetDamage()
        {
            int damage = -1;
            while(damage < 0)
            {
                Console.WriteLine("Please enter damage value:");
                int.TryParse(Console.ReadLine(), out damage);
            }

            return damage;
        }
    }
}
