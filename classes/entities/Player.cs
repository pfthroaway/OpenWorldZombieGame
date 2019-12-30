using OpenWorldZombieGame.Classes.Items;
using System.Collections.Generic;

namespace OpenWorldZombieGame.Classes.Entities
{
    /// <summary>Represents the entity that will be used for the <see cref="Player"/>.</summary>
    public class Player : LivingEntity
    {
        /// <summary>The currently equipped <see cref="Weapon"/>.</summary>
        public Weapon Weapon { get; set; } = new Weapon();

        /// <summary>The piece of <see cref="Armor"/> currently equipped on the head.</summary>
        public Armor HeadArmor { get; set; } = new Armor();

        /// <summary>The piece of <see cref="Armor"/> currently equipped on the body.</summary>
        public Armor BodyArmor { get; set; } = new Armor();

        /// <summary>The piece of <see cref="Armor"/> currently equipped on the legs.</summary>
        public Armor LegArmor { get; set; } = new Armor();

        /// <summary>The currently active <see cref="Quest"/>.</summary>
        public Quest CurrentQuest { get; set; } = new Quest();

        /// <summary>All currently available <see cref="Quest"/>s.</summary>
        public List<Quest> AllQuests { get; set; } = new List<Quest>();
    }
}