using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnDEngine.Characters;
using DnDEngine.Characters.Skills;
using DnDEngine.Characters.Feats;

namespace DnDEngine.Services
{
    public class SkillService
    {
        public static IEnumerable<ICharacter> CrossClass(IEnumerable<ICharacter> characters, Skill skill)
        {
            return characters.Where(x => x.Skills.Contains(skill));
        }
        public static IEnumerable<ICharacter> CharactersWithRanks(IEnumerable<ICharacter> characters,Skill skill)
        {
            return characters.Where(x => x.Skills.FirstOrDefault(i => i == skill )?.Ranks >= 1);
        }
        public static int? RollSkill(ICharacter character, Skill skill)
        {
            var feats = character.Feats.Where(x => x.Type == FeatTypes.Skill && x.Skills.Any(i => i == skill))?.Sum(x => x.Bonus);
            return Roller.DiceRoller.RollD20(1) +
                character.Skills.FirstOrDefault(x => x == skill)?.Ranks + feats +
                character.BaseStats.GetStat(skill.BaseStat);
        }
        
        public static int AddSkillRank(ICharacter character, Skill skill)
        {
            var s = character.Skills.FirstOrDefault(x => x == skill);           
            if (s.Ranks < character.Jobs.Sum(x => x.HitPoints.Count()))
            {
                return skill.Ranks++;
            }
            return skill.Ranks; 
        }
        public static int SubtractSkillRank(ICharacter character,Skill skill, int originalRank)
        {
            var s = character.Skills.FirstOrDefault(x => x == skill);
            if (s.Ranks > originalRank)
            {
                return skill.Ranks--;
            }
            return skill.Ranks;
        }
        public static int GetSkillBonus(ICharacter character,Skill skill)
        {
            var totalSkill = character.Skills.FirstOrDefault(x => x == skill).Ranks
                + character.Feats.Where(x => x.Type == FeatTypes.Skill && x.Skills.Any(i => i == skill)).Sum(x => x.Bonus) +
                character.BaseStats.GetStat(skill.BaseStat);         

                return 1;
        }
    }
}
