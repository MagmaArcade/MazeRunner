﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Runner
{
    public class Move : Command
    {
        public Move() :
            base(new string[] { "move", "stare", "glimpse" })
        {

        }

        public override string Execute(Player p, string[] text)
        {
            string error = "Error in move input.";
            string _moveDir;

            switch (text.Length)
            {
                case 1:
                    return "Move where?";

                case 2:
                    _moveDir = text[1].ToLower();
                    break;

                case 3:
                    _moveDir = text[2].ToLower();
                    break;

                default:
                    return error;
            }

            GameObject _path = p.Location.Locate(_moveDir);
            if (_path != null)
            {
                if (_path.GetType() != typeof(Path))
                    return "Could not find the " + _path.Name;
                p.Move((Path)_path);
                return "You have moved " + _path.FirstId + " through a " + _path.Name + " to the " + p.Location.Name + ".\r\n\n" +
                    p.Location.FullDescription;
            }
            else
            {
                return "Could not find any Path";

            }
        }
    }
}
  
