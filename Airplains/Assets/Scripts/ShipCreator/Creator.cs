
namespace Assets.ShipCreator
{
    public class Creator
    {
        #region Fields

        private IProduct _creatorShip;

        #endregion


        #region Methods

        public void CreatProduct(string shipSymb, string modulSymb, string weaponSymb)
        {
            switch (shipSymb)
            {
                case "A":
                    _creatorShip = new ShipACreator();
                    if (modulSymb.Length > 2 || weaponSymb.Length > 2) { return; }
                    _creatorShip.Operation(modulSymb, weaponSymb);
                    break;
                case "B":
                    _creatorShip = new ShipBCreator();
                    if (modulSymb.Length > 3 || weaponSymb.Length > 2) { return; }
                    _creatorShip.Operation(modulSymb, weaponSymb);
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
