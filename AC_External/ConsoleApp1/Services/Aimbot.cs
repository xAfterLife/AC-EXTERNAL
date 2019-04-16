using System.Threading;
using System.Threading.Tasks;

namespace AC_External
{
    public static class Aimbot
    {
        private static bool run = false;

        public static void Run(bool newThread = false)
        {
            if (run == false)
            {
                run = true;
                if (newThread)
                {
                    new Thread(new ThreadStart(TAimbot)).Start();
                }
                else
                {
                    TAimbot();
                }
            }
        }

        public static void Stop()
        {
            run = false;
        }

        private static void TAimbot()
        {
            Task.Factory.StartNew(() =>
            {
                while (run)
                {
                    while (Configuration.memory.Keystate(MemoryHandler.VirtualKeyStates.VK_CONTROL))
                    {
                        foreach (Player p in Enemies.list)
                        {
                            p.UpdatePlayer(Configuration.memory.Read(p.Address, 252));
                        }
                        WriteAngles();
                        Task.Delay(1);
                    }
                }
            });
        }

        public static float GetJaw()
        {
            return Maths.GetJawFloat(Maths.VectorSubtcractFloat(GetVector(Enemies.GetClosest() + Offsets.headPos), GetVector(Configuration.LocalPlayer + Offsets.headPos)));
        }

        public static float GetPitch()
        {
            return Maths.GetPitchFloat(Maths.VectorSubtcractFloat(GetVector(Enemies.GetClosest() + Offsets.headPos), GetVector(Configuration.LocalPlayer + Offsets.headPos)));
        }

        public static void WriteAngles()
        {
            Configuration.memory.WriteFloat(Configuration.LocalPlayer + Offsets.pitch, GetPitch());
            Configuration.memory.WriteFloat(Configuration.LocalPlayer + Offsets.yaw, GetJaw());
        }

        private static Maths.SVector<float> GetVector(int Base)
        {
            return new Maths.SVector<float>(Configuration.memory.ReadFloat(Base), Configuration.memory.ReadFloat(Base + 0x4), Configuration.memory.ReadFloat(Base + 0x8));
        }
    }
}
