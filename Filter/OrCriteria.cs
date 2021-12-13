using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Character> meetCriteria(BindingList<Character> characters)
        {
            BindingList<Character> firstCriteriaItems = filterCriteria.meetCriteria(characters);
            BindingList<Character> otherCriteriaItems = otherCriteria.meetCriteria(characters);

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
