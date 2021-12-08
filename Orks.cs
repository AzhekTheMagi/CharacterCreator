using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public abstract class Orks : IRace
    {
        protected string name;

        public abstract List<int> getStatList();
        public abstract void setStatList(int str, int dex, int con, int smarts, int wis, int cha);
        public abstract string getName();
        public abstract void setName(string name);
        public abstract string getDescription();
        public abstract string getSkill();
        public abstract int getHitPoints();
    }
}
