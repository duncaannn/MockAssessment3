﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public abstract class Villager
    {
        public int Hunger { get; set; }
        

        public Villager()
        {

            this.Hunger=Hunger;
        }
        
       public abstract int Farm();
    }
}
