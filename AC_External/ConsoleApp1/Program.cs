using System.Diagnostics;
using System.Threading;

namespace AC_External
{
    public unsafe class Program
    {
        private static void Main(string[] args)
        {
            #region GetProcess
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == Configuration.GameName)
                {
                    Configuration.memory = new MemoryHandler(p.Id, p);
                    continue;
                }
            }
            #endregion

            Configuration.Initialize();

            #region MainLoop
            while (true)
            {
                if (Configuration.memory.Keystate(MemoryHandler.VirtualKeyStates.VK_F1))
                {
                    Aimbot.Run();
                }
                if (Configuration.memory.Keystate(MemoryHandler.VirtualKeyStates.VK_F2))
                {
                    Aimbot.Stop();
                }
                Thread.Sleep(1);
            }
            #endregion
        }

        #region Methods
        public static Player GetPlayer(int MemoryAddress)
        {
            return new Player(Configuration.memory.Read(MemoryAddress, 252), MemoryAddress);
        }
        #endregion
    }
}
