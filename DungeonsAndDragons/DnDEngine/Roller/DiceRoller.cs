using System;

namespace DnDEngine.Roller
{
    public static class DiceRoller
    {
        public static int RollD100()
        {
            return new Random().Next(1, 100);
        }

        public static int RollD20()
        {
            return new Random().Next(1, 20);
        }

        public static int RollD12()
        {
            return new Random().Next(1, 12);
        }

        public static int RollD10()
        {
            return new Random().Next(1, 10);
        }

        public static int RollD8()
        {
            return new Random().Next(1, 8);
        }

        public static int RollD6()
        {
            return new Random().Next(1, 6);
        }

        public static int RollD4()
        {
            return new Random().Next(1, 4);
        }
    }
}