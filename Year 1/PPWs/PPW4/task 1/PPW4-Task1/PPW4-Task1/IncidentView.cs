using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPW4_Task1
{
    public partial class IncidentViewBox : Form
    {

        // defines the place we want to store submitted data
        string sFileName = "Incidents.txt";

        internal static int iCurrentIncident = 0;

        

        public IncidentViewBox()
        {
            InitializeComponent();

            

            // fetch the line needed for that specific ID
            int iCurrentLine = ((iCurrentIncident - 1) * 8) + 1;


            // Set the id on screen
            txtID.Text = Convert.ToString(iCurrentIncident);

            // Set the name of the person
            txtName.Text = File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First();

            iCurrentLine++;

            // set the incident type
            txtIncidentType.Text = File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First();

            iCurrentLine++;

            // set the description
            txtDescription.Text = File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First();

            iCurrentLine++;

            // set the location
            txtLocation.Text = File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First();

            iCurrentLine++;

            // if treatment was checked, check it now
            if (File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First() == "True")
            {
                chkTreatment.Checked = true;
            }
            if (File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First() == "False")
            {
                chkTreatment.Checked = false;
            }

            iCurrentLine++;
            // if followup was checked, check it now

            if (File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First() == "True")
            {
                chkFollowup.Checked = true;
            }
            if (File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First() == "False")
            {
                chkFollowup.Checked = false;
            }

            iCurrentLine++;

            txtTreatmentDesc.Text = File.ReadLines(sFileName).Skip(iCurrentLine).Take(1).First();

        }


    }
}
