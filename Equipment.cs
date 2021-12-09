using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public abstract class Equipment : IEquipment
    {
        protected double weight;

        public abstract List<string> getPropertiesList();
        public abstract double getWeight();
        public abstract void setWeight(double weight);
    }
}
