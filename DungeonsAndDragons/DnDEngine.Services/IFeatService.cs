using DnDEngine.Characters;
using DnDEngine.Characters.Feats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDEngine.Services
{
    public interface IFeatService
    {
        IEnumerable<ICharacter> CharactersWithFeat(IEnumerable<ICharacter> characters, Feat feat);
        IEnumerable<ICharacter> LearnableCharacters(IEnumerable<ICharacter> characters, Feat feat);

        void UseFeat();
    }
}
