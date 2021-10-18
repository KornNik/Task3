using UnityEngine;
using Assets.Ships;
using Assets.Helper;
using Assets.AssetsPath;

namespace Assets.ShipCreator
{
    public class ShipBCreator : IProduct
    {
        public Ship Operation(string modulSymb, string weaponSymb)
        {
            var ship = CustomResources.Load<Ship>(AssetsPathShip.Ships[ShipType.ShipB]);
            var shipB = Object.Instantiate(ship, Vector3.zero, Quaternion.identity);
            shipB.AddModuls(modulSymb);
            shipB.AddWeapons(weaponSymb);

            return shipB;
        }
    }
}
