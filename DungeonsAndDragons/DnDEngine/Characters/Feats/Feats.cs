using System.Collections.Generic;
using DnDEngine.Characters.Skills;

namespace DnDEngine.Characters.Feats
{
    // currentlyh tourning all feat types into seperate interfaces inheriting from IFeat
    // will need to figurte out logic
    public enum FeatTypes
    {
        Skill,
        Armor,
        Weapon,
        Combat,
        General,
        Race,
        Epic,
        Job


    }
    public  class Feat
    {
        public int Id { get; set; }                      
        public string Name { get; set; }
        public FeatTypes Type { get; set; }
        public List<Skill> Skills { get; set; }
        public int ArmorId { get; set; }
        public int WeaponId { get; set;} 
        public int Bonus { get; set; }       
    }
 

}

