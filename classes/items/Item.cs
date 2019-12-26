using OpenWorldZombieGame.Enums;

namespace OpenWorldZombieGame.Classes.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public int Value { get; set; }
    }
}