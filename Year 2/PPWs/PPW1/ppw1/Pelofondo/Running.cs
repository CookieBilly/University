using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelofondo
{

    // Running is a session
    public class Running : Session
    {

        // private variables
        private double dDistance;

        // public property's
        public double DDistance { get => dDistance; set => dDistance = value; }

        // tostring (overridden)
        public override string ToString()
        {

            // Give us a tailored tostring based on information
            return base.ToString() + " Average distance - " + dDistance;

        }

        // constructor
        public Running(int piId, string psTitle, int piDuration, int piDifficulty, string psInstructor, string psDescription, DateTime psDate, double pdDistance) : base(piId, psTitle, piDuration, piDifficulty, psInstructor, psDescription, psDate)
        {
            // set the passed in Distance to the classes Distance variable
            dDistance = pdDistance;
        }
    }
}
