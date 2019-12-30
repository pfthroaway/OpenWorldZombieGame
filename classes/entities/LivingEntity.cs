using OpenWorldZombieGame.Classes.Items;
using System.Collections.Generic;
using System.Linq;

namespace OpenWorldZombieGame.Classes.Entities
{
    public class LivingEntity
    {
        public string Name { get; set; }

        public List<Item> Inventory { get; set; } = new List<Item>();

        /// <summary>Gets all Items of specified Type.</summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>Items of specified Type</returns>
        internal List<T> GetItemsOfType<T>() => Inventory.OfType<T>().ToList();
    }
}