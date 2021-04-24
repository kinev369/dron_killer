using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dron;

namespace Dron
{
    public class Dron
    {
        private float ChanceEvasion = 0.15; 


        private DronWeapon Weapon { get; set; }

        public Dron(DronWeapon _weapon)
        {
            Weapon = _weapon;
        }

        public void ChangeWeapon(DronWeapon _weapon)
        {
            Weapon = _weapon;
        }

        public void DoAttack()
        {
            Weapon.Shot();
        }

        private bool EvasionAvailable()
        {
            return random.NextDouble() <= ChanceEvasion;
        }
        public void MoveInOneStep()
        {
            if (EvasionAvailable())
            {
                DoEvasion
            }
        }
    }
}