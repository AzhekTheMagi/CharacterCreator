using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Observer
{
    public class EquipmentObserver
    {
        private List<IEquipmentObserver> observers;
        private IEquipment equipment;

        public EquipmentObserver(IEquipment equipment)
        {
            observers = new List<IEquipmentObserver>();
            this.equipment = equipment;
        }

        public void addObserver(IEquipmentObserver observer)
        {
            this.observers.Add(observer);
        }

        public void removeObserver(IEquipmentObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (IEquipmentObserver observer in observers)
            {
                observer.update(equipment);
            }
        }
    }
}
