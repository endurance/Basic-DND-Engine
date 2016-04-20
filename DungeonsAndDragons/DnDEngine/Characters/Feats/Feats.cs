using System.Collections.Generic;
using DnDEngine.Characters.Skills;

namespace DnDEngine.Characters.Feats
{
    // currentlyh tourning all feat types into seperate interfaces inheriting from IFeat
    // will need to figurte out logic
    public interface IFeat
    {
        int Id { get; set; }        
        string Name { get; set; }
        void activateFeat();
    }

    public interface ISkillFeat:IFeat
    {
        List<Skill> Skills { get; set; }
        int Bonus { get; set; }
    }

    public interface ICombatFeat : IFeat
    {
        
        int Bonus { get; set; }
    }

    public interface IWeaponFeat : IFeat
    {
        int WeaponId { get; set; }
        int Bonus { get; set; }
    }

    public interface IArmorFeat : IFeat
    {
        int ArmorId { get; set; }
        int Bonus { get; set; }
    }

}

