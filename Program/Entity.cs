﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Entity
    {
        protected string name;

        public Entity(string name)
        {
            this.name = name;
        }
        
    }
}
