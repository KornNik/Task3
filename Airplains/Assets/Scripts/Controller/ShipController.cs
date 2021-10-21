using UnityEngine;
using Assets.UI;
using Assets.Services;

namespace Assets.Controller
{
    class ShipController : IExecute, IInitialization, IListnerScreen
    {
        #region Fields

        private bool _isActive;

        #endregion


        #region IInitialization

        public void Initialization()
        {
            ScreenInterface.GetInstance().AddObserver(ScreenType.GameMenu, this);
        }

        #endregion


        #region IExecute

        public void Execute()
        {
            if (!_isActive) return;


            foreach (var item in Services.Services.Instance.ShipServices.ships)
            {
                if (item.IsDead) { return; }
                item.Attack();
            }
        }

        private void OnHealthChangedDebug(float health, string name)
        {
            Debug.Log("Health" + health + " " + name);
        }
        private void OnShieldChangedDebug(float shield, string name)
        {
            Debug.Log("Shield" + shield+" "+name);
        }

        #endregion


        #region IListenerScreen

        public void ShowScreen()
        {
            _isActive = true;
            foreach (var item in Services.Services.Instance.ShipServices.ships)
            {
                item.HealthChanged += OnHealthChangedDebug;
                item.ShieldChanged += OnShieldChangedDebug;
            }
        }

        public void HideScreen()
        {
            _isActive = false;
            foreach (var item in Services.Services.Instance.ShipServices.ships)
            {
                item.HealthChanged -= OnHealthChangedDebug;
                item.ShieldChanged -= OnShieldChangedDebug;
            }
        }

        #endregion
    }
}
