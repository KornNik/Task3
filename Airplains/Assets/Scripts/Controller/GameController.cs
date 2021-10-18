using UnityEngine;
using Assets.UI;

namespace Assets.Controller
{
    class GameController : MonoBehaviour
    {
        #region Fields

        private Controllers _controllers;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _controllers = new Controllers();
            Initialization();
            Application.targetFrameRate = 60;
            ScreenInterface.GetInstance().Execute(ScreenType.MainMenu);
        }

        private void Update()
        {
            for (var i = 0; i < _controllers.Length; i++)
            {
                _controllers[i].Execute();
            }
        }

        #endregion


        #region Methods

        public void Initialization()
        {
            _controllers.Initialization();
        }

        #endregion
    }
}
