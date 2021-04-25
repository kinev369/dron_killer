using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronKiller
{
  public interface IWeapon
    {
        void ShotInDron(float shotX, float shotY, float presonX, float presonY, ArrayList<Dron> drons);
    }
}
