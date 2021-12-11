using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Filter
{
    public class AndCriteria : IFilterCriteria
    {
        private IFilterCriteria filterCriteria;
        private IFilterCriteria otherCriteria;

        public AndCriteria(IFilterCriteria filterCriteria, IFilterCriteria otherCriteria)
        {
            this.filterCriteria = filterCriteria;
            this.otherCriteria  = otherCriteria;
        }

        public List<Character> meetCriteria(List<Character> characters)
        {
            List<Character> firstCriteriaCharacter = this.filterCriteria.meetCriteria(characters);

            return this.otherCriteria.meetCriteria(firstCriteriaCharacter);
        }
    }
}
