using System;
using System.Collections.Generic;

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
        string Name { get; set; }
        BaseStat BaseStat { get; set; }
        List<int> SkillPoints { get; set; }
         
    }
    // Skills will be bare bones, as will the services
    // Much like an actual Table Top Game , We should let the story designer
    // come up with the results of rolls, and we will just make sure we are rolling right
    // Also this allows you to set up a repository if you will so that other table tops
    // or iterations can be made and just inserted in a table and then injecterd in ISkill Objects

    public static class SkillService
    {
        public static ISkill GetSkill(ICharacter character, string skillName)
        {
            return null;
        }

        public static void UpdateSkillPoints(ICharacter character, string skillName,int points)
        {
            
        }

        public static void RollSkill(ICharacter character, string skillName,string synergySkill

        

    }
}