using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DnDEngine.Characters.Feats;
using System;

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
    
    public interface ISkill
    {
         Guid Id { get; set; }
         string Name { get; set; }
         int BaseStatId { get; set; }
         int Ranks { get; set; }
         void UseSkill();
    }  

    public class Skill :ISkill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int BaseStatId { get; set; }
        public int Ranks { get; set; }
        public virtual void UseSkill()
        {
            //dothings
            Console.WriteLine($"{Roller.DiceRoller.RollD20(1) + Ranks}"); 
        }
    }

    public class Intimidate:Skill
    {
        public override void UseSkill()
        {
            base.UseSkill();
        }
    }

    public class Search : Skill
    {
        public override void UseSkill()
        {
            base.UseSkill();
        }
    }

    public class Perception : Skill
    {
        public override void UseSkill()
        {
            base.UseSkill();
        }
    }

    public class Stealth:Skill
    {
        public override void UseSkill()
        {
            base.UseSkill();
        }
    }
    // Skills will be bare bones, as will the services
    // Much like an actual Table Top Game , We should let the story designer
    // come up with the results of rolls, and we will just make sure we are rolling right
    // Also this allows you to set up a repository if you will so that other table tops
    // or iterations can be made and just inserted in a table and then injecterd in ISkill Objects



   
    //public static class SkillService
    //{
        
    //    public static Skill Get(ICharacter character, string skillName)
    //    {
    //        if (character.Skills.All(s => s.Name != skillName)) return null;
    //        var skill = character.Skills.FirstOrDefault(i => i.Name == skillName);
    //        return skill;
    //    }

    //    public static void Add(ICharacter character, Skill skill)
    //    {
    //        if (character.Skills.Any(s => s == skill))
    //        {
    //            return;
    //        }
    //        character.Skills.Add(skill);
    //    }
    //    public static void Update(ICharacter character, string skillName,int points)
    //    {
    //        if (character.Skills.All(s => s.Name != skillName)) return;
    //        {
    //            var first = character.Skills.FirstOrDefault(s => s.Name == skillName);
    //            first.SkillPoints.Add(points);
    //        }
    //    }

    //    // Skill bonus 2 overloads
    //    public static int SkillBonus(ICharacter character, string skillName)
    //    {
    //        return Get(character, skillName).SkillPoints.Sum()
    //            + character.BaseStats.GetStat(Get(character, skillName).BaseStatId) 
    //            + (from ISkillFeat e 
    //               in character.Feats
    //               where e.Skills.Any(i => i.Name == skillName)
    //               select e.Bonus).Sum();
    //    }

    //    public static int SkillBonus(ICharacter character, string skillName, string synergySkill)
    //    {
    //        var skillBonus = Get(character, skillName).SkillPoints.Sum()
    //            + character.BaseStats.GetStat(Get(character, skillName).BaseStatId)
    //            + (from ISkillFeat e
    //               in character.Feats
    //               where e.Skills.Any(i => i.Name == skillName)
    //               select e.Bonus).Sum();
    //        if (character.Skills.Any(s => s.Name == synergySkill))
    //        {
    //            return skillBonus + 5;
    //        }
    //        return skillBonus;
    //    }

    //}

    
}