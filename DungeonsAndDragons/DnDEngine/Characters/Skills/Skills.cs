using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DnDEngine.Characters.Feats;

namespace DnDEngine.Characters.Skills
{
    public enum BaseStat
    {
        Strength,
        Dexterity,
        Constitution,
        Wisdom,
        Intelligence,
        Charisma
    }

    
    
    public class Skill
    {
        public string Name { get; set; }
        public BaseStat BaseStat { get; set; }
        public List<int> SkillPoints { get; set; }
    }

    // Skills will be bare bones, as will the services
    // Much like an actual Table Top Game , We should let the story designer
    // come up with the results of rolls, and we will just make sure we are rolling right
    // Also this allows you to set up a repository if you will so that other table tops
    // or iterations can be made and just inserted in a table and then injecterd in ISkill Objects



   
    public static class SkillService
    {
        
        public static Skill GetSkill(ICharacter character, string skillName)
        {
            if (character.Skills.All(s => s.Name != skillName)) return null;
            var skill = character.Skills.FirstOrDefault(i => i.Name == skillName);
            return skill;
        }

        public static void AddSkill(ICharacter character, Skill skill)
        {
            if (character.Skills.Any(s => s == skill))
            {
                return;
            }
            character.Skills.Add(skill);
        }
        public static void UpdateSkillPoints(ICharacter character, string skillName,int points)
        {
            if (character.Skills.All(s => s.Name != skillName)) return;
            {
                var first = character.Skills.FirstOrDefault(s => s.Name == skillName);
                first.SkillPoints.Add(points);
            }
        }

        // Skill bonus 2 overloads
        public static int SkillBonus(ICharacter character, string skillName)
        {
            return GetSkill(character, skillName).SkillPoints.Sum()
                + character.BaseStats.GetStat(GetSkill(character, skillName).BaseStat) 
                + (from ISkillFeat e 
                   in character.Feats
                   where e.Skills.Any(i => i.Name == skillName)
                   select e.Bonus).Sum();
        }

        public static int SkillBonus(ICharacter character, string skillName, string synergySkill)
        {
            var skillBonus = GetSkill(character, skillName).SkillPoints.Sum()
                + character.BaseStats.GetStat(GetSkill(character, skillName).BaseStat)
                + (from ISkillFeat e
                   in character.Feats
                   where e.Skills.Any(i => i.Name == skillName)
                   select e.Bonus).Sum();
            if (character.Skills.Any(s => s.Name == synergySkill))
            {
                return skillBonus + 5;
            }
            return skillBonus;
        }

    }

    
}