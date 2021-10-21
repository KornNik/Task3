using UnityEngine;
using UnityEngine.UI;


namespace Assets.UI
{
    public sealed class MainMenu : BaseUi
    {
        #region Fields

        [SerializeField] private Button _startGameButton;
        [SerializeField] private Button _endGameButton;

        #endregion


        #region UnityMethods

        private void OnEnable()
        {
            _startGameButton.onClick.AddListener(StartGameButtonClick);
            _endGameButton.onClick.AddListener(EndGameButtonClick);
        }

        private void OnDisable()
        {
            _startGameButton.onClick.RemoveListener(StartGameButtonClick);
            _endGameButton.onClick.RemoveListener(EndGameButtonClick);
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
        private void EndGameButtonClick()
        {
            Application.Quit();
        }

        #endregion
    }
}
