namespace Assets.Ships
{
    public class ShipStats
    {
        #region Fields

        public float MaxHealth;
        public float MaxShield;
        public float ShieldRecovery;

        #endregion


        #region ClassLifeCycle

        public ShipStats(float maxHealth, float maxShield, float shieldRecovery)
        {
            MaxHealth = maxHealth;
            MaxShield = maxShield;
            ShieldRecovery = shieldRecovery;
        }

        #endregion
    }
}
