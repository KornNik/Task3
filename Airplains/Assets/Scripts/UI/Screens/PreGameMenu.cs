using UnityEngine;
using UnityEngine.UI;
using Assets.ShipCreator;

namespace Assets.UI
{
    public sealed class PreGameMenu : BaseUi
    {
        #region Fields

        [SerializeField] private Button _startGameButton;
        [SerializeField] private InputField _inputShipField;
        [SerializeField] private InputField _inputWeaponField;
        [SerializeField] private InputField _inputModulField;
        [SerializeField] private Button _creatShipButton;

        private Creator _creator;

        #endregion


        #region UnityMethods

        private void OnEnable()
        {
            _startGameButton.onClick.AddListener(StartGameButtonClick);
            _creatShipButton.onClick.AddListener(CreatShipClick);
            _creator = new Creator();
        }

        private void OnDisable()
        {
            _startGameButton.onClick.RemoveListener(StartGameButtonClick);
            _creatShipButton.onClick.RemoveListener(CreatShipClick);
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

        private void CreatShipClick()
        {
            Debug.Log(_inputShipField.text);
            _creator.CreatProduct(_inputShipField.text, _inputModulField.text,_inputWeaponField.text);
        }
        private void StartGameButtonClick()
        {
            ScreenInterface.GetInstance().Execute(ScreenType.GameMenu);
        }

        #endregion
    }
}
