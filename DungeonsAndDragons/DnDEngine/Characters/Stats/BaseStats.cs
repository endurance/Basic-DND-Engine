using System;
using DnDEngine.Characters.Skills;

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

        public int GetStat(BaseStat stat)
        {
            switch (stat)
            {
                case BaseStat.Strength:
                    return Strength;
                case BaseStat.Dexterity:
                    return Dexterity;
                    
                case BaseStat.Constitution:
                    return Constitution;
                case BaseStat.Wisdom:
                    return Wisdom;
                case BaseStat.Intelligence:
                    return Intelligence;
                case BaseStat.Charisma:
                    return Charisma;
                default:
                    throw new ArgumentOutOfRangeException("stat", stat, null);
            }            
        }
    }
}