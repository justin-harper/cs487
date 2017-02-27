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
    public class Zombie
    {
        public int Health {get; set; }
        public int MovementSpeed { get; set; }
        public bool Spawned { get; private set; }
        

        private Accessory dodad;

        public Zombie()
        {
            Health = 50;
            MovementSpeed = 1;
            Spawned = true;
        }

        public Zombie(Accessory thingy)
        {
            Health = 50;
            MovementSpeed = 1;
            Spawned = true;
           
            dodad = thingy;
        }

        public void DoDamage(DamageType dt)
        {
            if(dodad == null)
            {
                Health -= dt.Damage;
            }
            else if (dodad.Broken == false)
            {
                Health -= dodad.DoDamage(dt);
            }
            else
            {
                Health -= dt.Damage;
            }

            if (Health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            Spawned = false;
        }

        public override string ToString()
        {
            if(dodad == null)
            {
                return string.Format("R/{0}", Health);
            }
            else
            {
                if(dodad.Broken == true)
                {
                    return string.Format("R/{0}", Health);
                }
                else if(dodad is Cone)
                {
                    return string.Format("C/{0}", dodad.Health + Health);
                }
                else if(dodad is Bucket)
                {
                    return string.Format("B/{0}", dodad.Health + Health);
                }
                else if(dodad is ScreenDoor)
                {
                    return string.Format("S/{0}", dodad.Health + Health);
                }
                else
                {
                    return string.Format("U/{0}", dodad.Health + Health);
                }
            }
        }
    }
}
