using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class FactoryMaker
    {
        public static ICharacterFactory makeFactory(RaceType type)
        {
            switch (type)
            {
                case RaceType.Elf:
                    return new ElfFactory();
                case RaceType.Ork:
                    return new OrkFactory();
                default:
                    throw new ArgumentException("Character race currently not supported");
            }
        }
    }
}
