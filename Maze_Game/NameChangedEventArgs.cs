using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    // Creating an object for the arguments to pass into 
    // NameChangedDelgate which inherits from EventArgs: 
    public class NameChangedEventArgs : EventArgs 
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
