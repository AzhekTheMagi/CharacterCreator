using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CharacterCreator.Filter
{
    public class MagicCriteria : IFilterCriteria
    {
        public BindingList<Character> meetCriteria(BindingList<Character> characters)
        {
            BindingList<Character> magicCharacters = new BindingList<Character>();
            IRace elf = new Elf();

            foreach (Character character in characters)
            {
                if (character.getRace().ToString().Contains("Elf"))
                {
                    magicCharacters.Add(character);
                }
            }

            return magicCharacters;
        }
    }
}
