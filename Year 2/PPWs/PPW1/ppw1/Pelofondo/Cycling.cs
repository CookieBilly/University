using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelofondo
{

    // Cycling is a session
    public class Cycling : Session
    {

        // private variables
        private int iRPM;
        private int iResistance;

        // public propertys
        public int IRPM { get => iRPM; set => iRPM = value; }
        public int IResistance { get => iResistance; set => iResistance = value; }

        // tostring (overridden)
        public override string ToString()
        {

            // Give us a tailored tostring based on information in variables
            return base.ToString() + " Revolutions per minute - " + iRPM + " Resistance - " + iResistance;

        }

        // constructor
        public Cycling(int piId, string psTitle, int piDuration, int piDifficulty, string psInstructor, string psDescription, DateTime psDate, int piRPM, int piResistance): base(piId, psTitle, piDuration, piDifficulty, psInstructor, psDescription, psDate)
        {
            
            // set the passed in rpm to the classes rpm variable
            iRPM = piRPM;

            // set the passed in Resistance to the classes Resistance variable
            iResistance = piResistance;
        }
    }
}
