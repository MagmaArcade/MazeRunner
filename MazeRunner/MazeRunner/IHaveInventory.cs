using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Runner
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        GameObject Take(string id);
        void Put(Item item);
        string Name { get; }
    }
}
