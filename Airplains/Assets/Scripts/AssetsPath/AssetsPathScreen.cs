using System.Collections.Generic;
using Assets.UI;

namespace Assets.AssetsPath
{
    sealed class AssetsPathScreen
    {
        #region Fields

        public static readonly Dictionary<ScreenType, string> Screens = new Dictionary<ScreenType, string>
        {
            {
                ScreenType.Canvas, "GUI/Screen/GUI_Screen_Canvas"
            },
            {
                ScreenType.MainMenu, "GUI/Screen/GUI_Screen_MainMenu"
            },
            {
                ScreenType.GameMenu, "GUI/Screen/GUI_Screen_GameMenu"
            },
            {
                ScreenType.PreGameMenu,"GUI/Screen/GUI_Screen_PreGameMenu"
            }
        };

        #endregion
    }
}
