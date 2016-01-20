using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDEngine.Characters.Races;

namespace DnDEngine.Characters
{
    public interface ICharacter
    {
        IRace Race { get; set; }
        int Age { get; set; }
    }
}
