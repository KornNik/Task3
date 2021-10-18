using UnityEngine;
using Assets.Moduls;
using Assets.Weaponry;
using System.Collections;

namespace Assets.Ships
{
    public abstract class Ship : MonoBehaviour, IDamageable
    {
        #region Fields

        protected float _currentHealth;
        protected float _currentShield;

        protected ShipStats _shipStats;

        protected Modul[] _moduls;
        protected Weapon[] _weapons;

        #endregion


        #region ClassLifeCycle

        protected virtual void Awake()
        { 

        }

        #endregion


        #region Methods

        protected virtual void Attack()
        {
            foreach(var item in _weapons)
            {
                item.Fire(transform.position, transform.forward);
            }
        }

        protected virtual void RegenShield()
        {
            _currentShield += _shipStats.ShieldRecovery;
        }

        public void TakeDamage(float damage)
        {
            _currentHealth -= damage;
        }

        public virtual void AddModuls(string modulsSymb)
        {
            for (int j = 0; j < modulsSymb.Length; j++)
            {
                for (int i = 0; i < _moduls.Length; i++)
                {
                    if (_moduls[i] == null)
                    {
                        switch (modulsSymb[j])
                        {
                            case 'A':
                                _moduls[i] = new ModulA(ref _shipStats.MaxHealth);
                                break;
                            case 'B':
                                _moduls[i] = new ModulB(ref _shipStats.MaxShield);
                                Debug.Log(_shipStats.MaxShield);
                                break;
                            case 'C':
                                _moduls[i] = new ModulC();
                                break;
                            case 'D':
                                _moduls[i] = new ModulD(ref _shipStats.ShieldRecovery);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        public virtual void AddWeapons(string weaponSymbs)
        {
            for (int j = 0; j < weaponSymbs.Length; j++)
            {
                for (int i = 0; i < _weapons.Length; i++)
                {
                    if (_weapons[j] == null)
                    {
                        switch (weaponSymbs[j])
                        {
                            case 'A':
                                _weapons[i] = new WeaponA();
                                break;
                            case 'B':
                                _weapons[i] = new WeaponB();
                                break;
                            case 'C':
                                _weapons[i] = new WeaponC();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        protected IEnumerator PassiveRegen()
        {
            while (_currentShield < _shipStats.MaxShield)
            {
                yield return new WaitForSeconds(1f);
                _currentShield += _shipStats.ShieldRecovery;
            }
        }

        #endregion
    }
}
