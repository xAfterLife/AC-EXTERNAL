using System;
using System.Collections.Generic;

namespace AC_External
{
    public static class Configuration
    {
        public static MemoryHandler memory;
        public static List<int> PEntityList = new List<int>();
        public static Int32 LocalPlayer;
        public static Int32 EntityList;
        public const string GameName = "ac_client";
        public const Int32 PlayerAmount = 33;

        public static void Initialize()
        {
            Configuration.EntityList = Configuration.memory.ReadInt(Offsets.BaseAddress + Offsets.EntityList);
            Configuration.LocalPlayer = Configuration.memory.ReadInt(Offsets.BaseAddress + Offsets.LocalPlayer);
            Configuration.PEntityList = GetEntityList(PlayerAmount);
            Enemies.self = Program.GetPlayer(Configuration.LocalPlayer);
            Enemies.list.Add(Enemies.self);
            foreach (int i in Configuration.PEntityList)
            {
                Enemies.list.Add(Program.GetPlayer(i));
            }
        }

        private static List<int> GetEntityList(uint PlayerCount)
        {
            List<int> retList = new List<int>();
            for (int i = 1; i <= PlayerCount; i++)
            {
                retList.Add(Configuration.memory.ReadInt(Configuration.EntityList + i * sizeof(int)));
            }
            return retList;
        }
    }
}
