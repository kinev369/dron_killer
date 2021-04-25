using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DronKiller;

namespace DronKiller
{
    public class Dron : GameElement
    {
        //private float ChanceEvasion = 0.15;
        //private float ViewingRadius = 50;

        public Dron(float x, float y, float speedPersonX, float speedPersonY)
        {
            X = x;
            Y = y;
            SpeedX -= speedPersonX;
            SpeedY -= speedPersonY;
        }

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

//        private bool EvasionAvailable()
//        {
//            return random.NextDouble() <= ChanceEvasion;
//        }

//        private void DoEvasionMove()
//        {

//        }

        public void MoveInOneStep()
        {
            //            if (EvasionAvailable())
            //            {
            //                DoEvasionMove();
            //            }

            X += (SpeedX + 0.5f) * (UnityEngine.Random.Range(0.0f, 1.0f) - 0.2f);
            Y += (SpeedY + 0.5f) * (UnityEngine.Random.Range(0.0f, 1.0f) - 0.2f);
        }


    }
}