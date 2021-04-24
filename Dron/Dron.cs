using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DronKiller;

namespace DronKiller
{
    public class Dron : GameElement
    {
        private float ChanceEvasion = 0.15; 


        private IWeapon Weapon { get; set; }

        public Dron(IWeapon _weapon)
        {
            Weapon = _weapon;
        }

        public void ChangeWeapon(IWeapon _weapon)
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

        private void DoEvasionMove()
        {

        }

        public void MoveInOneStep()
        {
            if (EvasionAvailable())
            {
                DoEvasionMove();
            }
        }
    }
}