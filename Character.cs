using CharacterCreator.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Character : IEquipmentObserver
    {
        string name;
        string gender;
        IRace race;
        List<IEquipment> equipmentList;
        ICharacterClass characterClass;

        public Character(string name, string gender, IRace race, ICharacterClass characterClass)
        {
            this.name = name;
            this.gender = gender;
            this.race = race;
            this.characterClass = characterClass;
            this.equipmentList = new List<IEquipment>();
        }

        public void update(IEquipment equipment)
        {
            //do something
        }

        public IRace getRace()
        {
            return this.race;
        }

        public string getName()
        {
            return this.name;
        }

        public string getGender()
        {
            return this.gender;
        }

        public List<IEquipment> getEquipmentList()
        {
            return this.equipmentList;
        }

        public ICharacterClass getCharacterClass()
        {
            return this.characterClass;
        }

        public void addEquipment(IEquipment equipment)
        {
            this.equipmentList.Add(equipment);
        }

        public bool removeEquipment(string equipment)
        {
            int index = this.equipmentList.FindIndex(x => x.getName() == equipment);

            if (index != -1)
            {
                equipmentList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
