using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Orc : IRace
    {
        private string description = "Aggressive, warlike, & live in clans";
        private string name;
        private string raceType = "Orc";

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
