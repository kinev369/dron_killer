using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronKiller
{
    public class GameElement
    {
        protected float x ;
        protected float y ;
        public float X { get{return x;}set{x = value;} }
        public float Y { get{return y;} set{y= value;} }
        protected const float g = 9.8f;
        protected float speedX;
        protected float speedY;
        public float SpeedX { get{return speedX;}set{speedX = value;} }
        public float SpeedY { get{return speedY;} set{ speedY = value; } }
    }
}
