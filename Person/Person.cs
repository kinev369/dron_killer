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
        private float time1;
        public Person()
        {
            x = 0;
            y = 0;
            invert = new Invertary();
        }
        public void ShotKill(double X, double Y)
        {
        }
        public void move()
        {
         x = x+speedX;  
        }
        public void moveY(float Y){
            y= y + Y;
        }
        public void jump(float time)
        {
                if(y == 0){
                    time1 = time;
                    
                }
                else
                  { 

                  }


                

        }
        public void take()
        {

        }
        
    }
}
