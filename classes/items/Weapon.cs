using OpenWorldZombieGame.Enums;

namespace OpenWorldZombieGame.Classes.Items
{
    public class Weapon : Item
    {
        public double Aggro, Damage, Range, Speed;
        public int AmmoCount;
        public WeaponType WeaponType;
    }
}