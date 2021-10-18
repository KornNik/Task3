using System;
using Assets.Moduls;
using Assets.Weaponry;

namespace Assets.Ships
{
    class ShipB : Ship
    {
        #region Fields


        #endregion


        #region ClassLifeCycle

        protected override void Awake()
        {
            base.Awake();
            _shipStats = new ShipStats(60,120,1);
            _weapons = new Weapon[2];
            _moduls = new Modul[3];
            _currentHealth = _shipStats.MaxHealth;
            _currentShield = _shipStats.MaxShield;
            StartCoroutine(PassiveRegen());
        }

        #endregion


        #region Methods


        #endregion
    }
}
