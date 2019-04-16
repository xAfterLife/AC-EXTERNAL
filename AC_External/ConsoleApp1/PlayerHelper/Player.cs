using System;

namespace AC_External
{
    public unsafe class Player
    {
        public float X => memory.X;
        public float Y => memory.Y;
        public float Z => memory.Z;
        public int Health => memory.Health;

        public int Address { get; }

        public Player(byte[] memDump, int address)
        {
            memory.MemoryDump = memDump;
            Address = address;
        }

        public void UpdatePlayer(byte[] memDump)
        {
            memory.MemoryDump = memDump;
        }

        private Memory memory = new Memory();
        private unsafe struct Memory
        {
            public byte[] MemoryDump { get; set; }
            public float X => BitConverter.ToSingle(MemoryDump, 0x34);
            public float Y => BitConverter.ToSingle(MemoryDump, 0x38);
            public float Z => BitConverter.ToSingle(MemoryDump, 0x3C);
            public int Health => BitConverter.ToInt32(MemoryDump, 0xF8);
        }
    }
}
