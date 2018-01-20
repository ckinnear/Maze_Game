using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    //Added ScoreTracker as an abstract base class:
    public abstract class ScoreTracker
    {
        //The following methods need to be defined by inherited classes:
        public abstract void AddScores(float score);
        public abstract ScoreBoardStats CalculateScoreBoardStats();
        public abstract void WriteGrades(TextWriter destination);

        //The following do not need to be defined by inherited classes:
        public string Name
        {
            get { return _name; }

            set
            {
                //Changed to throw an exception: 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                // if the name changed invoke the delegate:
                if (_name != value && NameChanged != null)
                //"NameChanged != null" makes sure theirs no NullReference 
                // Exception in the case of no subscriptions to NameChangedDelegate event 
                {
                    //Create a NameChangedEventArgs instance:
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    NameChanged(this, args);
                    //"this" will pass in the current PlayerScore object that we are in
                }

                _name = value;


            }

        }

        //Made this delegate an event so that the user cannot wipe out subscribers with "null"
        public event NameChangedDelgate NameChanged; //field of type NameChangedDelegate

        protected string _name;//changed to protected 

    }
}
