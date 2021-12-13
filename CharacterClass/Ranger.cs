using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    [Serializable]
    public class Ranger : ICharacterClass
    {
        private int attackModifier = 2;
        private string trait = "Stealth";

        public int getTraitValue()
        {
            return this.attackModifier;
        }

        public string getTrait()
        {
            return this.trait;
        }
    }
}
