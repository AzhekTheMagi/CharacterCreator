using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public interface IRace
    {
        public List<int> getStatList();
        public void setStatList(int str, int dex, int con, int smarts, int wis, int cha);
        public string getName();
        public void setName(string name);
        public string getDescription();
        public string getSkill();
        public int getHitPoints();
    }
}
