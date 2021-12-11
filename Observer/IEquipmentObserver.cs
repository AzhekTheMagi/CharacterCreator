using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Observer
{
    public interface IEquipmentObserver
    {
        public void update(IEquipment equipment);
    }
}
