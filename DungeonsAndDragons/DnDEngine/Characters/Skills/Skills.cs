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
    
    
 
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BaseStat BaseStat { get; set; }
        public int Ranks { get; set; }     
           
    }

   
    // Skills will be bare bones, as will the services
    // Much like an actual Table Top Game , We should let the story designer
    // come up with the results of rolls, and we will just make sure we are rolling right
    // Also this allows you to set up a repository if you will so that other table tops
    // or iterations can be made and just inserted in a table and then injecterd in ISkill Objects




  




}