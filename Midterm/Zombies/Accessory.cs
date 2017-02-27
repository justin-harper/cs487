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
    public abstract class Accessory
    {
        public int Health { get; protected set; }
        public bool Broken { get; protected set; }

        public virtual int DoDamage(DamageType dt)
        {
            Health -= dt.Damage;
            if (Health <= 0)
            {
                Broken = true;
                return Health;
            }
            return 0;
        }
    }

    class ScreenDoor : Accessory
    {
        public ScreenDoor()
        {
            Health = 25;
            Broken = false;
        }
        public override int DoDamage(DamageType dt)
        {
            if(dt.Catapult == true)
            {
                return dt.Damage;
            }
            else
            {
                Health -= dt.Damage;
                if(Health <= 0)
                {
                    Broken = true;
                    return Health;
                }
                return 0;
            }
        }
    }

    class Cone : Accessory
    {
        public Cone()
        {
            Health = 25;
            Broken = false;
        }
    }

    class Bucket : Accessory
    {
        public Bucket()
        {
            Health = 100;
            Broken = false;
        }
    }

    class None : Accessory
    {
        public override int DoDamage(DamageType dt)
        {
            return dt.Damage;
        }
    }
}
