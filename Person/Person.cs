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
        private float x_Position;
        private float y_Position;
        private IWeapon weapon;
        private IHolder holderv;
        private Invertary invert;
        public float x_get_Position
        {
            get { return x_Position; }
            set { x_Position = value; }
        }
        public float y_get_Position
        {
            get { return y_Position; }
            set { y_Position = value; }
        }

        public Person()
        {
            x_Position = 0;
            y_Position = 0;
            invert = new Invertary();
        }
        public void ShotKill(double X, double Y)
        {
        }
        public void move()
        {

        }
        public void jump()
        {

        }
        public void take()
        {

        }
        public Person(float X, float Y)
        {
            x_Position = X;
            y_Position = Y;

        }
    }
}
