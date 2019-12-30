using OpenWorldZombieGame.Enums;

namespace OpenWorldZombieGame.Classes.Items
{
    /// <summary>Represents a <see cref="Weapon"/> that can be used for attacking.</summary>
    public class Weapon : Item
    {
        /// <summary>The amount of damage the <see cref="Weapon"/> does.</summary>
        public double Damage { get; set; }

        /// <summary>The type of <see cref="Weapon"/>.</summary>
        public WeaponType WeaponType { get; set; }

        /// <summary>The amount of aggro the <see cref="Weapon"/> generates by being held or used.</summary>
        public double Aggro { get; set; }

        /// <summary>The maximum distance the <see cref="Weapon"/> can reach to attack.</summary>
        public double Range { get; set; }

        /// <summary>The speed at which the <see cref="Weapon"/> can attack.</summary>
        public double Speed { get; set; }

        /// <summary>The amount of ammunition currently available to the <see cref="Weapon"/>.</summary>
        public int CurrentAmmoCount { get; set; }

        /// <summary>The maximum amount of ammunition available to the <see cref="Weapon"/>.</summary>
        public int MaximumAmmoCount { get; set; }

        /// <summary>The currently selected type of ammunition.</summary>
        public AmmoType AmmoType { get; set; }
    }
}