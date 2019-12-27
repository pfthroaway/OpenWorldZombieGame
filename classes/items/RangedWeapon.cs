using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWorldZombieGame.Classes.Items
{
    public class RangedWeapon : Weapon
    {
        public AmmoType CurrentAmmoType;
        public int AmmoCount;
        public List<AmmoType> AcceptedAmmoTypes;
    }
}