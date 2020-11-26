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
    public partial class TreatmentReason : Form
    {

        bool bCompleted;

        public TreatmentReason()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try 
            {

                IncidentRecord.sSubmitTreatmentDescription = txtTreatmentGiven.Text;
                MessageBox.Show("Thanks for entering a description, click submit to submit.");
                this.Close();
                                
            }
            catch
            {
                MessageBox.Show("You must enter a valid treatment given");
            }

            
        }
    }
}
