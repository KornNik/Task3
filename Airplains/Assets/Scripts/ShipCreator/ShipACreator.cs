using UnityEngine;
using Assets.Ships;
using Assets.Helper;
using Assets.AssetsPath;


namespace Assets.ShipCreator
{
    public class ShipACreator : IProduct
    {
        public Ship Operation(string modulSymb, string weaponSymb)
        {
            var ship = CustomResources.Load<Ship>(AssetsPathShip.Ships[ShipType.ShipA]);
            var shipA = Object.Instantiate(ship, Vector3.zero, Quaternion.identity);
            shipA.AddModuls(modulSymb);
            shipA.AddWeapons(weaponSymb);

            return shipA;
        }
    }
}
