using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal interface IMaze
    {
        float MazePath();
        string MazeName { get; set; }
    }
}
