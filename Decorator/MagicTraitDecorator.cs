using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Decorator
{
    public class MagicTraitDecorator : EquipmentDecorator
    {
        string magicTrait;

        public MagicTraitDecorator(IEquipment equipment)
        {
            base.equipment = equipment;
        }

        public string getMagicTrait()
        {
            return this.magicTrait;
        }

        public void setMagicTrait(string magicTrait)
        {
            this.magicTrait = magicTrait;
        }
    }
}
