using UnityEngine;
using Assets.Ships;
using Assets.Helper;
using Assets.AssetsPath;

namespace Assets.ShipCreator
{
    class ShipBCreator : IProduct
    {
        private Vector3 _spawnPlace;
        private Quaternion _spawnRotation;

        public Ship Operation(string modulSymb, string weaponSymb)
        {
            CreateSpawn();
            var ship = CustomResources.Load<Ship>(AssetsPathShip.Ships[ShipType.ShipB]);
            var shipB = Object.Instantiate(ship, _spawnPlace, _spawnRotation);
            shipB.AddModuls(modulSymb);
            shipB.AddWeapons(weaponSymb);

            return shipB;
        }

        private void CreateSpawn()
        {
            _spawnPlace = new Vector3(0, 0, 2);
            _spawnRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
