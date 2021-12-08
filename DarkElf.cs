using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class DarkElf : Elf
    {
        private string description = "Pointy ears. Mean.";
        private string skill = "Stealth";
        private int hitPoints = 13;
        private List<int> statList;

        public override void setStatList(int str, int dex, int con, int smarts, int wis, int cha)
        {
            statList = new List<int>()
            {
                str,    //Strength
                dex,    //Dexterity
                con,    //Constitution
                smarts, //Intelligence
                wis,    //Wisdom
                cha     //Charm
            };
        }

        public override List<int> getStatList()
        {
            return this.statList;
        }

        public override string getName()
        {
            return base.name;
        }

        public override void setName(string name)
        {
            base.name = name;
        }

        public override string getDescription()
        {
            return this.description;
        }
        public override string getSkill()
        {
            return this.skill;
        }

        public override int getHitPoints()
        {
            return this.hitPoints;
        }
    }
}
