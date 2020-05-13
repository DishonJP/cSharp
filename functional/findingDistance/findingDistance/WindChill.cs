using System;

namespace functionalPrograms
{
    class WindChill
    {
        public static double findTemperature(int t,int v)
        {
            return 35.74 + 0.6215 * t + (0.4275*t-35.75)*Math.Pow(v,0.16);
        }
    }
}
