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
    public class DamageType
    {
        public bool PeaShooter{get; set;}
        public bool Catapult { get; set; }
        public int Damage { get; set; }

        public DamageType(bool PeaShooter, bool Catapult, int Damage)
        {
            this.PeaShooter = PeaShooter;
            this.Catapult = Catapult;
            this.Damage = Damage;
        }
    }
}
