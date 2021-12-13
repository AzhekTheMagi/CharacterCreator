using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CharacterCreator.Filter
{
    // Implementation adapted from https://www.tutorialspoint.com/design_pattern/filter_pattern.htm
    public interface IFilterCriteria
    {
        //public List<Character> meetCriteria(List<Character> characterList);
        public BindingList<Character> meetCriteria(BindingList<Character> characterList);
    }
}
