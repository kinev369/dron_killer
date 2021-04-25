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
        public Person()
        {
            x = 0;
            y = 0;
            invert = new Invertary();
        }
        public void ShotKill(double X, double Y)
        {
        }
        public void Move()
        {
         x = x+speedX;  
        }
        public void MoveY(float Y){
            y= y + Y;
        }
        public void Jump(float time)
        {
            if(y_begin_jump == 0){
                time_begin = time;
                y_begin_jump = y;
            }
            else{ 
                
                float t =  time-time_begin ;
                y = speedY*t - (g*t*t)/2;
            }
        }
        public void take()
        {

        }
        
    }
}
