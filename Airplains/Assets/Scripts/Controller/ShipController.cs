using UnityEngine;
using Assets.UI;
using Assets.ShipCreator;

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


        }

        #endregion


        #region IListenerScreen

        public void ShowScreen()
        {
            _isActive = true;
        }

        public void HideScreen()
        {
            _isActive = false;
        }

        #endregion
    }
}
