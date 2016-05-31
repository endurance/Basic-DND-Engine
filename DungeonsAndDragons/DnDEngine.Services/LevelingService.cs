using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDEngine.Characters.Jobs;
using DnDEngine.Characters;

namespace DnDEngine.Services
{
    public static class LevelingService
    {
        public static int addExperience(ICharacter character, int experience )
        {
            character.Experience += experience;
            return character.Experience;
        }
        public static int AddLevel(ICharacter character)
        {
            return character.Jobs.Sum(x => x.Level) + 1;
        }
        public static int GetCharacterLevel(ICharacter character)
        {
            return character.Jobs.Sum(x => x.Level);
        }
        public static int SetLevel(int level, ICharacter character)
        {            
            int newExperience = 0;
            for(int i = 1;i < level;i++)
            {
                newExperience += i * 1000;
            }
            character.Experience = newExperience;
            return level;
        }
        public static int ExperienceForLevelUp(ICharacter character)
        {
            int xForLevel = 0;
            for(int i = 1; i <= character.Jobs.Sum(x => x.Level); i++)
            {
                xForLevel += i* 1000;
            }
            return xForLevel - character.Experience;
        }
        public static bool IsLevelUp(ICharacter character)
        {
            if(ExperienceForLevelUp(character) <= 0)
            {
                return true;
            }
            return false;
        }
       
    }
}
