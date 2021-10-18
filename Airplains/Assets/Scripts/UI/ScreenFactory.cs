using UnityEngine;
using Assets.Helper;
using Assets.AssetsPath;

namespace Assets.UI
{
    class ScreenFactory
    {
        #region Fields

        private GameMenu _gameMenu;
        private MainMenu _mainMenu;
        private PreGameMenu _preGameMenu;
        private Canvas _canvas;

        #endregion


        #region ClassLifeCycles

        public ScreenFactory()
        {
            var resources = CustomResources.Load<Canvas>(AssetsPathScreen.Screens[ScreenType.Canvas]);
            _canvas = Object.Instantiate(resources, Vector3.one, Quaternion.identity);
        }

        #endregion


        #region Methods

        public GameMenu GetGameMenu()
        {
            if (_gameMenu == null)
            {
                var resources = CustomResources.Load<GameMenu>(AssetsPathScreen.Screens[ScreenType.GameMenu]);
                _gameMenu = Object.Instantiate(resources, _canvas.transform.position, Quaternion.identity, _canvas.transform);
            }
            return _gameMenu;
        }

        public MainMenu GetMainMenu()
        {
            if (_mainMenu == null)
            {
                var resources = CustomResources.Load<MainMenu>(AssetsPathScreen.Screens[ScreenType.MainMenu]);
                _mainMenu = Object.Instantiate(resources, _canvas.transform.position, Quaternion.identity, _canvas.transform);
            }
            return _mainMenu;
        }

        public PreGameMenu GetPreGameMenu()
        {
            if (_preGameMenu == null)
            {
                var resources = CustomResources.Load<PreGameMenu>(AssetsPathScreen.Screens[ScreenType.PreGameMenu]);
                _preGameMenu = Object.Instantiate(resources, _canvas.transform.position, Quaternion.identity, _canvas.transform);
            }
            return _preGameMenu;
        }

        #endregion
    }
}
