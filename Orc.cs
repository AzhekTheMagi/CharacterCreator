using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Orc : IRace
    {
        private string description = "Orcs are disfigured humanoid carnivores, standing approximately 5'11 to 6'2, " +
            "weighing from 180 to 280 lbs. They are easily noticeable due to their green to gray skin, lupine ears, " +
            "lower canines resembling boar tusks, and their muscular builds. Orcs stand in a bent over shape making " +
            "them appear as ape-like humans.";
        private string name;

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
    }
}
