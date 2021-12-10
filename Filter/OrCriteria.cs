using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Filter
{
    public class OrCriteria : IFilterCriteria
    {
        private IFilterCriteria filterCriteria;
        private IFilterCriteria otherCriteria;

        public OrCriteria(IFilterCriteria filterCriteria, IFilterCriteria otherCriteria)
        {
            this.filterCriteria = filterCriteria;
            this.otherCriteria  = otherCriteria;
        }

        public List<Character> meetCriteria(List<Character> characters)
        {
            List<Character> firstCriteriaItems = filterCriteria.meetCriteria(characters);
            List<Character> otherCriteriaItems = otherCriteria.meetCriteria(characters);

            foreach (Character character in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(character))
                {
                    firstCriteriaItems.Add(character);
                }
            }

            return firstCriteriaItems;
        }
    }
}
