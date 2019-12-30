using OpenWorldZombieGame.Classes.Items;
using OpenWorldZombieGame.Enums;
using System.Collections.Generic;

namespace OpenWorldZombieGame.Classes.Entities
{
    public class Player : LivingEntity
    {
        public WeaponType CurrentWeaponType { get; set; }
        public Weapon Weapon { get; set; } = new Weapon();
        public Armor Armor { get; set; } = new Armor();
        public Quest CurrentQuest { get; set; } = new Quest();
        public List<Quest> AllQuests { get; set; } = new List<Quest>();
    }
}