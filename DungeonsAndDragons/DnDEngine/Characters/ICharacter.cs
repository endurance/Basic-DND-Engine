using System.Collections.Generic;
using DnDEngine.Characters.Races;
using DnDEngine.Characters.Skills;
using DnDEngine.Characters.Stats;
using DnDEngine.Characters.Feats;
using DnDEngine.Characters.Jobs;
namespace DnDEngine.Characters
{
    public interface ICharacter
    {
        IRace Race { get; set; }
        int Age { get; set; }
        List<Skill> Skills { get; set; }
        List<Feat> Feats { get; set; }
        List<Job> Jobs { get; set; } 
        BaseStats BaseStats { get; set; }        
        int Experience { get; set; }
        bool DoSomething(string name);
    }
}