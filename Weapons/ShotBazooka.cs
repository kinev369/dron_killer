using System;
using System.Collections;
using DronKiller;
using System.Runtime.dll;

namespace DronKiller
{
    public class ShotBazooka
    {
        
        public static ArrayList<int> DronIsShotedHit(float shotX, float shotY, float presonX, float presonY, ArrayList<Dron> drons)
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

                distance = Math.Abs(coofX * dron.X + coofY * dron.Y + coofFree) / Math.Sqrt(coofX * coofX + coofY * coofY);
                if (distance <= dron.radius)
                {
                    if (Math.Sqrt(Math.Pow(presonY - dron.Y, 2) + Math.Pow(presonX - dron.X, 2)) < minDistDron)
                    {
                        minDistDron = Math.Sqrt(Math.Pow(presonY - dron.Y, 2) + Math.Pow(presonX - dron.X, 2));
                        result = indexDron;
                    }
                }
                indexDron++;
            }

            if (result != -1)
            {
                ArrayList<int> resultArr = new ArrayList<int>();
                resultArr.Add(result);
                return new ArrayList(resultArr);
            }

            return null;
        }
    }
}