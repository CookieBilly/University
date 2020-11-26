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
    public partial class FollowupSearch : Form
    {

        // will be set to the ID we want to search for
        int iSearchID = 0;


        // defines the place we want to store submitted data
        string sFileName = "Incidents.txt";

        public FollowupSearch()
        {
            InitializeComponent();
            // the current id

            int iCurrentID = 0;

            // the loop we're currently on
            int iCurrentLoop = 0;

            // the amount of people who need followups
            int iRequirefollowup = 0;

            // line fetcher variable
            int iLineFetch = 0;

            // loop files to find which id we're up to
            using (StreamReader sr = new StreamReader(sFileName, true))
            {

                // tried using sr.peek - crashed the program.
                while (sr.ReadLine() != null)
                {
                    // increase the loop value
                    iCurrentLoop++;
                    // add the incident ID to the selection menu

                    // if the current number is divisible by 8 (amount of lines per ID)
                    if (iCurrentLoop % 8 == 0)
                    {
                        // then we've found a new ID
                        iCurrentID++;

                        // math to find the type of incident
                        iLineFetch = (((iCurrentID - 1) * 8) + 6);

                        // if it's false, add 1 person to require followup
                        if (File.ReadLines(sFileName).Skip(iLineFetch).Take(1).First() == "True")
                        {
                            iRequirefollowup++;
                            lstSelection.Items.Add(iCurrentID);
                        }

                    }
                }

            }

            // set the label for followups required
            lblFollowupCount.Text = iRequirefollowup.ToString() + " followups required";

        }

        private void lstSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dont need to try this as it's added by me above.
            iSearchID = Convert.ToInt32(lstSelection.SelectedItem);

            IncidentViewBox.iCurrentIncident = iSearchID;

            //declare and instantiate the new form
            IncidentViewBox newIncidentView = new IncidentViewBox();

            //display the new form 
            newIncidentView.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // dont need to try this as it's added by me above.
            iSearchID = Convert.ToInt32(lstSelection.SelectedItem);

            IncidentViewBox.iCurrentIncident = iSearchID;

            //declare and instantiate the new form
            IncidentViewBox newIncidentView = new IncidentViewBox();

            //display the new form 
            newIncidentView.Show();
        }
    }
}
