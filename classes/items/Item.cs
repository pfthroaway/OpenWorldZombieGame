using OpenWorldZombieGame.Enums;

namespace OpenWorldZombieGame.Classes.Items
{
    /// <summary>Represents an <see cref="Item"/> that can be picked up or used.</summary>
    public abstract class Item
    {
        /// <summary>The name of the <see cref="Item"/>.</summary>
        public string Name { get; set; }

        /// <summary>The description of the <see cref="Item"/>.</summary>
        public string Description { get; set; }

        /// <summary>The <see cref="ItemType"/> of the <see cref="Item"/>.</summary>
        public ItemType Type { get; set; }

        /// <summary>The value of the <see cref="Item"/>.</summary>
        public int Value { get; set; }
    }
}