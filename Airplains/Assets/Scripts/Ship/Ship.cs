using UnityEngine;
using Assets.Moduls;
using Assets.Weaponry;
using System;
using System.Collections;

namespace Assets.Ships
{
    public abstract class Ship : MonoBehaviour, IDamageable
    {
        #region Fields

        [SerializeField] private Transform WeaponBarrel;

        public Action Die;
        public Action<float, string> HealthChanged;
        public Action<float, string> ShieldChanged;

        protected float _currentHealth;
        protected float _currentShield;

        protected ShipStats _shipStats;

        protected Modul[] _moduls;
        protected Weapon[] _weapons;

        private Coroutine _coroutine;
        private bool _isDead;

        #endregion

        #region Properties

        public bool IsDead { get { return _isDead; } }

        #endregion


        #region ClassLifeCycle

        protected virtual void Awake()
        {
            Die += OnDie;
        }

        #endregion


        #region Methods

        public virtual void Attack()
        {
            foreach(var item in _weapons)
            {
                item.UpdateTimer();
                item.Fire(WeaponBarrel.position, WeaponBarrel.forward);
            }
        }

        public void TakeDamage(float damage)
        {
            if (_isDead) return;
            if (_currentHealth <= 0)
            {
                Die?.Invoke();
                _isDead = true;
            }
            if (_currentShield > 0 && _currentShield > damage)
            {
                _currentShield -= damage;
                ShieldChanged?.Invoke(_currentShield, this.name);
                if (_coroutine == null)
                {
                    _coroutine = StartCoroutine(PassiveRegen());
                }
            }
            else
            {
                _currentHealth -= damage;
                HealthChanged?.Invoke(_currentHealth, this.name);
            }
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
                    if (_weapons[i] == null)
                    {
                        switch (weaponSymbs[j])
                        {
                            case 'A':
                                _weapons[i] = new WeaponA();
                                Debug.Log(_weapons[i].ToString());
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
            if (_currentShield == _shipStats.MaxShield) { _coroutine = null; }
            while (_currentShield < _shipStats.MaxShield)
            {
                yield return new WaitForSeconds(1f);
                _currentShield += _shipStats.ShieldRecovery;
            }
        }

        private void OnDie()
        {
            Debug.Log("Lose"+this.name);
        }
        #endregion
    }
}
