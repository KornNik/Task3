using System;
using Assets.Moduls;
using Assets.Weaponry;

namespace Assets.Ships
{
    class ShipA : Ship
    {
        #region Fields


        #endregion


        #region ClassLifeCycle

        protected override void Awake()
        {
            base.Awake();
            _shipStats = new ShipStats(100,80,1);
            _weapons = new Weapon[2];
            _moduls = new Modul[2];
            _currentHealth = _shipStats.MaxHealth;
            _currentShield = _shipStats.MaxShield;
        }

        #endregion


        #region Methods


        #endregion
    }
}
