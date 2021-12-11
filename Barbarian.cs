using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Barbarian : ICharacterClass
    {
        private int strengthModifier = 4;
        private string trait = "Aggressive";

        public int getTraitValue()
        {
            return this.strengthModifier;
        }

        public string getTrait()
        {
            return this.trait;
        }
    }
}
