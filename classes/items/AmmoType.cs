namespace OpenWorldZombieGame.Classes.Items
{
    /// <summary>Represents the types of ammunition availble.</summary>
    public enum AmmoType
    {
        /// <summary>This <see cref="AmmoType"/> has no special abilities.</summary>
        Normal,

        /// <summary>This <see cref="AmmoType"/> can penetrate armor.</summary>
        AP,

        /// <summary>This <see cref="AmmoType"/> provides extra damage and precision.</summary>
        HP,

        /// <summary>This <see cref="AmmoType"/> explodes on impact.</summary>
        Explosive
    }
}