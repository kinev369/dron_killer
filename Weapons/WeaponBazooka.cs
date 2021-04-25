using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronKiller
{
    public class WeaponBazooka : Item, IWeapon
    {

        public List<int> ShotInDron(float shotX, float shotY, float presonX, float presonY, List<Dron> drons)
        {
            return ShotBazooka.DronIsShotedHit(shotX, shotY, presonX, presonY, drons);
        }


    }
}
