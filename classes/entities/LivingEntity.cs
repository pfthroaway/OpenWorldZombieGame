using OpenWorldZombieGame.Classes.Items;
using System.Collections.Generic;
using System.Linq;

namespace OpenWorldZombieGame.Classes.Entities
{
    /// <summary>Represents anything that is alive in the game.</summary>
    public class LivingEntity
    {
        /// <summary>The name of the entity.</summary>
        public string Name { get; set; }

        /// <summary>The items currently held by the entity.</summary>
        public List<Item> Inventory { get; set; } = new List<Item>();

        /// <summary>The amount of health the entity currently has.</summary>
        public int CurrentHealth { get; set; }

        /// <summary>The maximum amount of health the entity can have.</summary>
        public int MaximumHealth { get; set; }

        /// <summary>The ratio of current health to maximum health the entity currently has.</summary>
        public double HealthRatio => CurrentHealth * 1.0 / MaximumHealth;

        /// <summary>Gets all Items of specified Type.</summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>Items of specified Type</returns>
        internal List<T> GetItemsOfType<T>() => Inventory.OfType<T>().ToList();
    }
}