using UnityEngine;
using Assets.Ships;

namespace Assets.Weaponry
{
    public abstract class Weapon
    {
        #region Fields

        protected int _reloadTime;
        protected float _damage;
        protected RaycastHit _hitInfo;

        #endregion


        #region ClassLifeCycle

        public Weapon() { }

        #endregion


        #region Methods

        public virtual void Fire(Vector3 position, Vector3 direction)
        {
            if(Physics.Raycast(position, direction, out _hitInfo, 10f))
            {
                var damageableObj = _hitInfo.transform.gameObject.GetComponent<IDamageable>();
                if (damageableObj!=null)
                {
                    damageableObj.TakeDamage(_damage);
                }
            }
        }

        #endregion
    }
}
