using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public interface ICharacterClass
    {
        public int getTraitValue();
        public string getTrait();
    }
}
