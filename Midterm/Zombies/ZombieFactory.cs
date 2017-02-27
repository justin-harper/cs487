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
    class ZombieFactory
    {
        List<Zombie> Zomberts;

        public ZombieFactory()
        {
            Zomberts = new List<Zombie>();
        }

        public void SpawnRegularZombie()
        {
            Zomberts.Add(new Zombie());
        }

        public void SpawnConeZombie()
        {
            Zomberts.Add(new Zombie(new Cone()));
        }

        public void SpawnBucketZombie()
        {
            Zomberts.Add(new Zombie(new Bucket()));
        }

        public void SpawnScreenDoorZombie()
        {
            Zomberts.Add(new Zombie(new ScreenDoor()));
        }

        public string SpawnedZombies()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach(Zombie z in Zomberts)
            {
                sb.Append(z.ToString() + ",");
            }
            sb.Replace(",", "", sb.Length - 1, 1);
            sb.Append("]");

            return sb.ToString();
        }

        public void ShootPeaShooter(int Damage)
        {
            Zombie Zombert = Zomberts.FirstOrDefault();
            if(Zombert == null)
            {
                return;
            }
            Zombert.DoDamage(new DamageType(true, false, Damage));
            Zomberts.RemoveAll(x => x.Spawned == false);
        }
    }
}
