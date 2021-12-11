using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Filter
{
    public class MagicCriteria : IFilterCriteria
    {
        public List<Character> meetCriteria(List<Character> characters)
        {
            List<Character> magicCharacters = new List<Character>();
            IRace elf = new Elf();

            foreach (Character character in characters)
            {
                if (character.getRace().Equals(elf))
                {
                    magicCharacters.Add(character);
                }
            }

            return magicCharacters;
        }
    }
}
