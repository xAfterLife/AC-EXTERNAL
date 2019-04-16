using System;
using System.Collections.Generic;

namespace AC_External
{
    public static class Enemies
    {
        public static List<Player> list = new List<Player>();
        public static Player self;

        public static int GetClosest()
        {
            int retval = 0;
            double retDist = double.MaxValue;

            foreach (Player p in list.FindAll(p => p.Health > 0 && p.Health < 3000 && p.Address != self.Address))
            {
                double currDist = GetDist(p);
                if (currDist < retDist)
                {
                    retval = p.Address;
                    retDist = currDist;
                }
            }
            return retval;
        }

        public static unsafe double GetDist(Player target)
        {
            float dx = target.X - self.X;
            float dy = target.Y - self.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
