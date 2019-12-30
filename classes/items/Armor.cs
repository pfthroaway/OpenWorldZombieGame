using OpenWorldZombieGame.Enums;

namespace OpenWorldZombieGame.Classes.Items
{
    /// <summary>Represents a type of <see cref="Armor"/> that can be worn.</summary>
    public class Armor : Item
    {
        /// <summary>The amount of defense the <see cref="Armor"/> provides.</summary>
        public double Defense { get; set; }

        /// <summary>The type of <see cref="Armor"/>.</summary>
        public ArmorType ArmorType { get; set; }
    }
}