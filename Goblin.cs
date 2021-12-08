using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Goblin : Orks
    {
        private string description = "Goblins are small, black-hearted humanoids that lair in despoiled dungeons and other dismal settings.";
        private string skill = "Intimidation";
        private int hitPoints = 15;
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
