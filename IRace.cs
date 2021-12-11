using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public interface IRace
    {
        public string getName();
        public void setName(string name);
        public string getDescription();
    }
}
