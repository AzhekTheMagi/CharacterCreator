using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    [Serializable]
    public abstract class Equipment : IEquipment
    {
        protected double weight;
        protected string name;

        public abstract List<string> getPropertiesList();
        public abstract double getWeight();
        public abstract void setWeight(double weight);
        public abstract string getName();
        public abstract void setName(string name);

        public override string ToString()
        {
            return this.name;
        }
    }
}
