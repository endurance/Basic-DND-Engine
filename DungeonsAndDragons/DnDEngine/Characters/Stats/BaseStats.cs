using System;
using System.Linq;

namespace DnDEngine.Characters.Stats
{
    public class BaseStats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public static BaseStats operator +(BaseStats left, BaseStats right)
        {
            return new BaseStats
            {
                Strength = left.Strength + right.Strength,
                Dexterity = left.Dexterity + right.Dexterity,
                Constitution = left.Constitution + right.Constitution,
                Intelligence = left.Intelligence + right.Intelligence,
                Wisdom = left.Wisdom + right.Wisdom,
                Charisma = left.Charisma + right.Charisma
            };
        }
    }
}