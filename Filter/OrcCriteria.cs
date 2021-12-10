using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Filter
{
    public class OrcCriteria : IFilterCriteria
    {
        public List<Character> meetCriteria(List<Character> characters)
        {
            List<Character> orcCharacters = new List<Character>();
            IRace orc = new Orc();

            foreach (Character character in characters)
            {
                if (character.getRace().Equals(orc))
                {
                    orcCharacters.Add(character);
                }
            }

            return orcCharacters;
        }
    }
}
