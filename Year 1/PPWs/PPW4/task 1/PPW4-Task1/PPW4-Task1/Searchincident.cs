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
    public partial class Searchincident : Form
    {


        // will be set to the ID we want to search for
        int iSearchID = 0;


        // defines the place we want to store submitted data
        string sFileName = "Incidents.txt";

        public Searchincident()
        {
            InitializeComponent();

            int iCurrentID = 0;
            int iCurrentLoop = 0;

            // loop files to find which id we're up to
            using (StreamReader sr = new StreamReader(sFileName, true))
            {

                // tried using sr.peek - crashed the program.
                while (sr.ReadLine() != null)
                {
                    // increase the loop value
                    iCurrentLoop++;
                    // add the incident ID to the selection menu

                    if (iCurrentLoop % 8 == 0)
                    {
                        iCurrentID++;
                        lstSelection.Items.Add(iCurrentID);
                    }
                }
            }

            lblIncidentCount.Text = iCurrentID.ToString() + " Incident reported";
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
    }
}
