using System.ComponentModel;

namespace CharacterCreator.Filter
{
    public class OrcCriteria : IFilterCriteria
    {
        public BindingList<Character> meetCriteria(BindingList<Character> characters)
        {
            BindingList<Character> orcCharacters = new BindingList<Character>();
            IRace orc = new Orc();

            foreach (Character character in characters)
            {
                if (character.getRace().ToString().Contains("Orc"))
                {
                    orcCharacters.Add(character);
                }
            }

            return orcCharacters;
        }
    }
}
