using UnityEngine;
using UnityEngine.UI;

namespace Assets.UI
{
    public sealed class GameMenu : BaseUi
    {
        #region Fields


        #endregion


        #region UnityMethods

        private void OnEnable()
        {

        }

        private void OnDisable()
        {

        }

        #endregion


        #region Methods

        public override void Show()
        {
            gameObject.SetActive(true);
            ShowUI.Invoke();
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
            HideUI.Invoke();
        }

        private void Call()
        {
            ScreenInterface.GetInstance().Execute(ScreenType.MainMenu);
        }

        #endregion
    }
}
