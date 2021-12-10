using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Decorator
{
    public abstract class EquipmentDecorator : IEquipment
    {
        protected IEquipment equipment;

        public List<string> getPropertiesList()
        {
            return this.equipment.getPropertiesList();
        }

        public double getWeight()
        {
            return this.equipment.getWeight();
        }

        public void setWeight(double weight)
        {
            this.equipment.setWeight(weight);
        }
    }
}
