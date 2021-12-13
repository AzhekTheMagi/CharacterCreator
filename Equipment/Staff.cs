using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    [Serializable]
    public class Staff : Equipment
    {
        List<string> properties;

        public Staff()
        {
            properties = new List<string>()
            {
                "bludgeoning",
                "arcane focus",
                "utility"
            };
        }

        public override List<string> getPropertiesList()
        {
            return this.properties;
        }

        public override double getWeight()
        {
            return base.weight;
        }

        public override void setWeight(double weight)
        {
            base.weight = weight;
        }

        public override string getName()
        {
            return base.name;
        }

        public override void setName(string name)
        {
            base.name = name;
        }

        public override string ToString()
        {
            return "Staff";
        }
    }
}
