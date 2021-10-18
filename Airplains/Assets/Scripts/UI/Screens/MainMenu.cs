using UnityEngine;
using UnityEngine.UI;


namespace Assets.UI
{
    public sealed class MainMenu : BaseUi
    {
        #region Fields

        [SerializeField] private Button _startGameButton;

        #endregion


        #region UnityMethods

        private void OnEnable()
        {
            _startGameButton.onClick.AddListener(StartGameButtonClick);
        }

        private void OnDisable()
        {
            _startGameButton.onClick.RemoveListener(StartGameButtonClick);
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

        private void StartGameButtonClick()
        {
            ScreenInterface.GetInstance().Execute(ScreenType.PreGameMenu);
        }

        #endregion
    }
}
