﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class BattleAxe : Equipment
    {
        List<string> properties;

        public BattleAxe()
        {
            properties = new List<string>()
            {
                "versatile"
            };
        }

        public override List<string> getPropertiesList()
        {
            return this.properties;
        }

        public override double getWeight()
        {
            return base.weight;
        }

        public override void setWeight(double weight)
        {
            base.weight = weight;
        }
    }
}
