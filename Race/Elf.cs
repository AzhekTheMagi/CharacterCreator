using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    [Serializable]
    public class Elf : IRace
    {
        private string description = "Magical, graceful, pointy earred, & hates orcs.";
        private string name;
        private string raceType = "Elf";

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public override string ToString()
        {
            return this.raceType;
        }
    }
}
