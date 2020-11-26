using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelofondo
{
    public abstract class Session
    {

        //private attributes
        private int iId;
        private string sTitle;
        private int iDuration;
        private DateTime dtDate;
        private int iDifficulty;
        private string sInstructor;
        private string sDescription;
        
        // public property's
        public string SInstructor { get => sInstructor; set => sInstructor = value; }
        public int IId { get => iId; set => iId = value; }
        public string STitle { get => sTitle; set => sTitle = value; }
        public string SDescription { get => sDescription; set => sDescription = value; }
        public int IDifficulty { get => iDifficulty; set => iDifficulty = value; }
        public int IDuration { get => iDuration; set => iDuration = value; }
        public DateTime DtDate { get => dtDate; set => dtDate = value; }



        // method to fetch string representation
        public override string ToString()
        {

            // Give us a tailored tostring based on information
            return "Session ID - " + iId + " Date - " + dtDate.ToString() + " Title - " + sTitle + " Instructor - " + sInstructor + " Description - " + sDescription + " Difficulty - " + iDifficulty + " Duration - " +iDuration;

        }

        // constructor
        public Session(int piId, string psTitle, int piDuration, int piDifficulty, string psInstructor, string psDescription, DateTime pdtDate)
        {

            // take the variables passed in and set these to the classes properties.
            iId = piId;
            sTitle = psTitle;
            iDuration = piDuration;
            iDifficulty = piDifficulty;
            sInstructor = psInstructor;
            sDescription = psDescription;
            dtDate = pdtDate;
    }

    }
}
