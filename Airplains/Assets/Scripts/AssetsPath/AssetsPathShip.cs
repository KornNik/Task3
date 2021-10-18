using System.Collections.Generic;
using Assets.Ships;

namespace Assets.AssetsPath
{
    sealed class AssetsPathShip
    {
        #region Fields

        public static readonly Dictionary<ShipType, string> Ships = new Dictionary<ShipType, string>
        {
            {ShipType.ShipA,"Ships/Ships_ShipA" },
            {ShipType.ShipB,"Ships/Ships_ShipB" },
        };

        #endregion
    }
}
