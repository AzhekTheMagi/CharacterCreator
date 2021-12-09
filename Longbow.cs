﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class Longbow : Equipment
    {
        List<string> properties;

        public Longbow()
        {
            properties = new List<string>()
            {
                "ammunition",
                "heavy",
                "two-handed"
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
