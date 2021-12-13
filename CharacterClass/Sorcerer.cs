using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    [Serializable]
    public class Sorcerer : ICharacterClass 
    {
        private int mana = 10;
        private string trait = "Magic Wielder";

        public int getTraitValue()
        {
            return this.mana;
        }

        public string getTrait()
        {
            return this.trait;
        }
    }
}
