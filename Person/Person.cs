using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DronKiller;

namespace DronKiller
{
    public class Person : GameElement
    {
        private IWeapon weapon;
        private Invertary invert;
        private float time_begin;
        public float y_begin_jump= 0;
        private float time1;


        public bool jumps;
        public Person()
        {
            x = 0;
            y = 0;
            speedX = 0.1f;
            speedY = 0.1f; 
            jumps = false;
            invert = new Invertary();
            weapon = new WeaponBazooka();

        }

        public List<int> ShotKill(float shotX, float shotY, List<Dron> drons)
        {
            return weapon.ShotInDron(shotX, shotY, X, Y, drons);
        }

        public void Move()
        {
         x = x+speedX;  
        }

        public void MoveY(float time){
            if (jumps == true)
            {
                float t = time - time_begin;
                y = y + speedY * t - (g * t * t) / 2;
                if ((2 * speedY / g) < t)
                {
                    jumps = false;
                    time_begin = 0;
                }

            }

        }

        public void Jump(float time)
        {
            time_begin = time;
            jumps = true;
        }

        public void Take()
        {

        }
        
    }
}
