using System;
using DnDEngine.Characters.Races;
using DnDEngine.Characters.Stats;

namespace DnDEngine.Characters.Age
{

    public class AgeEffectService
    {
        private BaseStats MiddleAge => new BaseStats()
        {
            Strength = -1,
            Dexterity = -1,
            Constitution = -1,
            Intelligence = 1,
            Wisdom = 1,
            Charisma = 1
        };
        private BaseStats OldAge => new BaseStats()
        {
            Strength = -2,
            Dexterity = -2,
            Constitution = -2,
            Intelligence = 2,
            Wisdom = 2,
            Charisma = 2
        };
        private BaseStats VenerableAge => new BaseStats()
        {
            Strength = -3,
            Dexterity = -3,
            Constitution = -3,
            Intelligence = 3,
            Wisdom = 3,
            Charisma = 3
        };

        public BaseStats CalculateAgeEffects(ICharacter character)
        {
            int age = character.Age;
            var status = character.Race.GetAgeStatus(age);
            switch (status)
            {
                case AgeStatus.MiddleAge:
                    return MiddleAge;
                case AgeStatus.Old:
                    return OldAge;
                case AgeStatus.Venerable:
                    return VenerableAge;
                case AgeStatus.None:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
