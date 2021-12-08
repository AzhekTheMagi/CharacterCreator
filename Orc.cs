﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Orc : Orks
    {
        private string description = "Orcs are savage humanoids with stooped postures, piggish faces, and prominent teeth that resemble tusks.";
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
