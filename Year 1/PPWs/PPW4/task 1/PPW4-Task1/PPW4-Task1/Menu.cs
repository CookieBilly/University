using System;
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



    public partial class Menu : Form
    {



        public Menu()
        {
            InitializeComponent();
        }

        // Go to the record incident form when button clicked
        private void btnRecordIncident_Click(object sender, EventArgs e)
        {
                    

            //declare and instantiate the new form
            IncidentRecord newIncidentRecord = new IncidentRecord();

            //display the new form 
            newIncidentRecord.Show();

        }

        // Go to the search incident form when button clicked
        private void btnViewIncidents_Click(object sender, EventArgs e)
        {

            //declare and instantiate the new form
            Searchincident Searchincident = new Searchincident();

            //display the new form 
            Searchincident.Show();
        }

        // Go to the stats form when button clicked
        private void btnStats_Click(object sender, EventArgs e)
        {

            //declare and instantiate the new form
            Statistics newStatistics = new Statistics();

            //display the new form 
            newStatistics.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declare and instantiate the new form
            FollowupSearch newFollowupSearch = new FollowupSearch();

            //display the new form 
            newFollowupSearch.Show();
        }
    }
}
