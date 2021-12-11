using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Elf : IRace
    {
        private string description = "Elves are a magical people of otherworldly grace, living in the" +
            " world but not entirely part of it. They live in places of ethereal beauty, in the midst of" +
            " ancient forests or in silvery spires glittering with faerie light, where soft music drifts" +
            " through the air and gentle fragrances waft on the breeze";
        private string name;

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return this.description;
        }
    }
}
