﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Runner
{
    public abstract class Command : Identifiable_Object
    {
        public Command(string[] ids) : base(ids)
        {

        }
        abstract public string Execute(Player p, string[] text);
    }
}
