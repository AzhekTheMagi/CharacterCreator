using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Filter
{
    // Implementation adapted from https://www.tutorialspoint.com/design_pattern/filter_pattern.htm
    public interface IFilterCriteria
    {
        public List<Character> meetCriteria(List<Character> characterList);
    }
}
