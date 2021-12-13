using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Character> meetCriteria(BindingList<Character> characters)
        {
            BindingList<Character> firstCriteriaCharacter = this.filterCriteria.meetCriteria(characters);

            return this.otherCriteria.meetCriteria(firstCriteriaCharacter);
        }
    }
}
