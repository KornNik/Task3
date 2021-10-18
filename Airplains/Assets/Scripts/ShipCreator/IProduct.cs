using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Ships;

namespace Assets.ShipCreator
{
    public interface IProduct
    {
        Ship Operation(string modulSymb, string weaponSymb);
    }
}
