using UnityEngine;
using Assets.Ships;
using Assets.Helper;

namespace Assets.Weaponry
{
    public abstract class Weapon
    {
        #region Fields

        protected int _reloadTime;
        protected float _damage;
        protected RaycastHit _hitInfo;
        protected Timer _timer = new Timer();

        private bool _isReadyFire = true;

        #endregion


        #region ClassLifeCycle

        public Weapon() { }

        #endregion


        #region Methods

        public virtual void UpdateTimer()
        {
            _timer.UpdateTimer();
            if (_timer.IsEvent())
            {
                ReadyShoot();
            }
        }

        public virtual void Fire(Vector3 position, Vector3 direction)
        {
            Debug.DrawRay(position, direction, Color.red, 10f);

            if (!_isReadyFire) { return; }
            if (Physics.Raycast(position, direction, out _hitInfo, 10f))
            {
                var damageableObj = _hitInfo.transform.gameObject.GetComponent<IDamageable>();
                if (damageableObj != null)
                {
                    damageableObj.TakeDamage(_damage);
                }
            }
            _isReadyFire = false;
            _timer.StartTimer(_reloadTime);

        }

        private void ReadyShoot()
        {
            _isReadyFire = true;
        }

        #endregion
    }
}
