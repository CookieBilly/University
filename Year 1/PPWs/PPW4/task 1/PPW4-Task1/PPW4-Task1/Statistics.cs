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
    public partial class Statistics : Form
    {
        // defines the place we want to store submitted data
        string sFileName = "Incidents.txt";

        public Statistics()
        {
            InitializeComponent();

            // the current id

            int iCurrentID = 0;

            // the loop we're currently on
            int iCurrentLoop = 0;

            // the amount of people who need followups
            int iRequirefollowup = 0;

            // amount of public incidents
            int iPublicIncidents = 0;

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
                        iLineFetch = (((iCurrentID - 1) * 8) + 2);

                        // if it's public, add 1 to public incidents
                        if (File.ReadLines(sFileName).Skip(iLineFetch).Take(1).First() == "General Public")
                        {
                            iPublicIncidents++;
                        }

                        // Works out which line the followup answer is on
                        iLineFetch = iLineFetch + 4;

                        // if it's false, add 1 person to require followup
                        if (File.ReadLines(sFileName).Skip(iLineFetch).Take(1).First() == "True")
                        {
                            iRequirefollowup++;
                        }

                    }
                }

            }

            // set the label of the ncidents reported
            lblIncidentCount.Text = iCurrentID.ToString() + " Incident reported";

            // set the label for followups required
            lblFollowupAmount.Text = iRequirefollowup.ToString() + " followups required";

            // work out the percentage of public incidents
            double dPercentage = Convert.ToDouble(iPublicIncidents) / Convert.ToDouble(iCurrentID);

            lblPercentage.Text = dPercentage.ToString("P");
        }


    }

}