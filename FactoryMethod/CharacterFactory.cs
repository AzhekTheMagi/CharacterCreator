using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class CharacterFactory : ICharacterFactory
    {
        public IRace createRace(string str)
        {
            Type t = Type.GetType("CharacterCreator." + str);
            Object o = Activator.CreateInstance(t);
            IRace irace = (IRace)o;

            return irace;
        }

        public IEquipment createEquipment(string str)
        {
            Type t = Type.GetType("CharacterCreator." + str);
            Object o = Activator.CreateInstance(t);
            IEquipment iequipment = (IEquipment)o;

            return iequipment;
        }

        public ICharacterClass createCharacterClass(string str)
        {
            Type t = Type.GetType("CharacterCreator." + str);
            Object o = Activator.CreateInstance(t);
            ICharacterClass icharacterclass = (ICharacterClass)o;

            return icharacterclass;
        }
    }
}
