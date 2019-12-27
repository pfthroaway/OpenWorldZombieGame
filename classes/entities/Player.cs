using OpenWorldZombieGame.Classes.Items;
using OpenWorldZombieGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWorldZombieGame.Classes.Entities
{
    public class Player : LivingEntity
    {
        public WeaponType CurrentWeaponType { get; set; }
        public MeleeWeapon MeleeWeapon { get; set; } = new MeleeWeapon();
        public RangedWeapon RangedWeapon { get; set; } = new RangedWeapon();
        public HeadArmor HeadArmor { get; set; } = new HeadArmor();
        public BodyArmor BodyArmor { get; set; } = new BodyArmor();
        public LegArmor LegArmor { get; set; } = new LegArmor();
        public Quest CurrentQuest { get; set; } = new Quest();
        public List<Quest> AllQuests { get; set; } = new List<Quest>();
    }
}