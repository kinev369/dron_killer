using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronKiller
{
  public interface IWeapon
    {
        List<int> ShotInDron(float shotX, float shotY, float presonX, float presonY, List<Dron> drons);
    }
}
