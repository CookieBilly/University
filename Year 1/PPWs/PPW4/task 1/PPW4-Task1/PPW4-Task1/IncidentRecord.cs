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
    public partial class IncidentRecord : Form
    {

        // define the ID variable at class level as it's used in multiple scopes
        int iCurrentID;

        // defines the place we want to store submitted data
        string sFileName = "Incidents.txt";

        internal static string sSubmitTreatmentDescription = "";

        public IncidentRecord()
        {
            InitializeComponent();

            // set the id at the top of the page by calling the get id function
            txtID.Text = Convert.ToString(GetCurrentID());


            cmbIncidentType.Items.Add("Participant");
            cmbIncidentType.Items.Add("Staff");
            cmbIncidentType.Items.Add("General Public");
        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

            // call the submit form function: true = submitted, false = errors whilst submitting
            bool bSubmit = SubmitForm();

            // If there's no errors, it'll clear the form and fetch a new ID so it can be used again.
            if (bSubmit == true)
            {
                MessageBox.Show("You have submitted an incident report");
                ClearForm();
                txtID.Text = Convert.ToString(GetCurrentID());
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ensures the person is wanting to clear the form

            //declare a DialogResult variable
            DialogResult drReply;

            // ask if they're sure
            drReply = MessageBox.Show("Are you sure you want to clear?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if they click yes, call function
            if (drReply == DialogResult.Yes)
            {
                ClearForm();
            }


        }

        // Function in order to clear the form (called by the button + called after submitting)
        private void ClearForm()
        {

            // sets everything to it's default (apart from ID, as this doesn't need to be cleared)

            txtName.Text = "";
            cmbIncidentType.Text = null;
            txtDescription.Text = "";
            txtLocation.Text = "";
            sSubmitTreatmentDescription = "";
            chkTreatment.Checked = false;
            chkFollowup.Checked = false;


        }
        // Function in order to clear the form (called by the button + called after submitting)
        internal bool SubmitForm()
        {
            string sSubmitName;
            string sSubmitType;
            string sSubmitDescription;
            string sSubmitLocation;
            bool sSubmitTreatment = false;
            bool sSubmitFollowup = false;

            // grab the name in the text box, save to var, validate using trycatch block
            try
            {
                sSubmitName = txtName.Text;
            }
            catch
            {
                MessageBox.Show("You must enter text into this box");
                txtName.Focus();
                txtName.SelectAll();

                // stops more errors from completing
                return false;

            }

            // check to ensure name is not empty
            if (txtName.Text == "")
            {
                MessageBox.Show("You must include a name");
                txtName.Focus();
                txtName.SelectAll();
                return false;

            }

            // grab the selection in the dropdown box, save to var, validate using trycatch block
            try
            {
                sSubmitType = cmbIncidentType.Text;
            }
            catch
            {
                MessageBox.Show("You must select an option");
                cmbIncidentType.Focus();
                cmbIncidentType.SelectAll();

                // stops more errors from completing
                return false;

            }


            // check to ensure incident type is not empty
            if (cmbIncidentType.Text == "")
            {
                MessageBox.Show("You must select a valid incident type");
                cmbIncidentType.Focus();
                cmbIncidentType.SelectAll();
                return false;

            }

            // grab the description in the text box, save to var, validate using trycatch block
            try
            {

                sSubmitDescription = txtDescription.Text;
            }
            catch
            {
                MessageBox.Show("You must describe the incident");
                txtDescription.Focus();
                txtDescription.SelectAll();

                // stops more errors from completing
                return false;

            }

            // check to ensure type is not empty
            if (txtDescription.Text == "")
            {
                MessageBox.Show("You must enter a description");
                txtDescription.Focus();
                txtDescription.SelectAll();
                return false;

            }

            // grab the location in the text box, save to var, validate using trycatch block
            try
            {
                sSubmitLocation = txtLocation.Text;
            }
            catch
            {
                MessageBox.Show("You must enter a location");
                txtLocation.Focus();
                txtLocation.SelectAll();

                // stops more errors from completing
                return false;

            }

            // check to ensure type is not empty

            if (txtLocation.Text == "")
            {

                MessageBox.Show("You must enter a valid location");
                txtLocation.Focus();
                txtLocation.SelectAll();
                return false;


            }

            // check to see if the person needs Followup

            if (chkFollowup.Checked == true)
            {
                sSubmitFollowup = true;
            }
            else
            {
                sSubmitFollowup = false;
            }

            // check to see if the person needs further treatment

            if (chkTreatment.Checked == true)
            {
                if(sSubmitTreatmentDescription == "")
                { 

                    // ask for description of treatment

                        //declare and instantiate the new form
                        TreatmentReason newTreatmentReason = new TreatmentReason();

                    //display the new form 
                    newTreatmentReason.Show();

                    return false;

                }

                sSubmitTreatment = true;

            }
            if (chkTreatment.Checked == false)
            {
                sSubmitTreatment = false;
                sSubmitTreatmentDescription = "n/a";

            }

            

            // put everything into an array
            String[] sSubmit = new String[] { txtID.Text, sSubmitName, sSubmitType, sSubmitDescription, sSubmitLocation, Convert.ToString(sSubmitTreatment), Convert.ToString(sSubmitFollowup), sSubmitTreatmentDescription };


            // every variable in array will be sent to the file
            for (int iIndex = 0; iIndex < sSubmit.Length; iIndex++)
            {
                using (StreamWriter outputFile = new StreamWriter(sFileName, true))
                {
                    outputFile.WriteLine(sSubmit[iIndex]);
                }

            }


            return true;

        }
        


        private int GetCurrentID()
        {

            int iCurrentLoop = 0;
            int iCurrentID = 0;

            // loop files to find which id we're up to
            using (StreamReader sr = new StreamReader(sFileName, true))
            {
                // tried using sr.peek - crashed the program.
                while (sr.ReadLine() != null)
                {
                    // increase the loop value
                    iCurrentLoop++;
                }
            }

            // Each entry creates 7 lines, divide by 7 to get the current ID.
            iCurrentID = iCurrentLoop / 8;

            // add 1 to the ID
            iCurrentID++;

            // return with the ID
            return iCurrentID;

        }



    }



}