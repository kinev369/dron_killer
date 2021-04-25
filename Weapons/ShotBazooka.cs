using System;
using System.Collections;
using DronKiller;
using System.Runtime;
using System.Collections.Generic;

namespace DronKiller
{
    public class ShotBazooka
    {
        
        public static List<int> DronIsShotedHit(float shotX, float shotY, float presonX, float presonY, List<Dron> drons)
        {
            float coofX, coofY, coofFree;
            float distance;
            int indexDron = 0;
            int result = -1;
            float minDistDron = 99;
            foreach (Dron dron in drons)
            {
                coofX = shotY - presonY;
                coofY = presonX - shotX;
                coofFree = presonY * shotX - presonX * shotY;

                distance = (float)(Math.Abs((coofX * dron.X) + coofY * dron.Y + coofFree) / Math.Sqrt(coofX * coofX + coofY * coofY));
                if (distance <= dron.Radius)
                {
                    if (Math.Sqrt(Math.Pow(presonY - dron.Y, 2) + Math.Pow(presonX - dron.X, 2)) < minDistDron)
                    {
                        minDistDron = (float)Math.Sqrt(Math.Pow(presonY - dron.Y, 2) + Math.Pow(presonX - dron.X, 2));
                        result = indexDron;
                    }
                }
                indexDron++;
            }

            if (result != -1)
            {
                List<int> resultArr = new List<int>();
                resultArr.Add(result);
                return resultArr;
            }

            return null;
        }
    }
}