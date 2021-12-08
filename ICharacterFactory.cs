using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    // CharacterFactory interface
    public interface ICharacterFactory
    {
        public IRace createRace(string str);
        public IEquipment createEquipment(string str);
        public ICharacterClass createCharacterClass(string str);
    }
}
