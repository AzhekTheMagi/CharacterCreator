using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public interface IEquipment
    {
        public List<string> getPropertiesList();
        public double getWeight();
        public void setWeight(double weight);
        public string getName();
        public void setName(string name);
    }
}
