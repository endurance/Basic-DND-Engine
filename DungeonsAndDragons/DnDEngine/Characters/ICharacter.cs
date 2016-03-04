using System.Collections.Generic;
using DnDEngine.Characters.Races;
using DnDEngine.Characters.Skills;
using DnDEngine.Characters.Stats;
using DnDEngine.Characters.Feats;
namespace DnDEngine.Characters
{
    public interface ICharacter
    {
        IRace Race { get; set; }
        int Age { get; set; }
        List<Skill> Skills { get; set; }
        List<IFeat> Feats { get; set; }
        BaseStats BaseStats { get; set; }
        bool DoSomething(string name);
    }
}