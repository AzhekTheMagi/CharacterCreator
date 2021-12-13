using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Decorator
{
    [Serializable]
    public class MagicTraitDecorator : EquipmentDecorator
    {
        string magicTrait;
        string type;

        public MagicTraitDecorator(IEquipment equipment)
        {
            base.equipment = equipment;
        }

        public string getMagicTrait()
        {
            return this.magicTrait;
        }

        public void setMagicTrait(string trait)
        {
            this.magicTrait = trait;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return this.type;
        }
    }
}
