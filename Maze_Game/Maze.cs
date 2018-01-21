using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public abstract class Maze : IMaze
    {

        public abstract float MazePath();

        public string MazeName
        {
            get { return _mazeName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Maze name cannot be null or empty");
                }
                 _mazeName = value;
            }
        }

        protected string _mazeName;
    }
}
