using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelofondo
{
    public partial class Form1 : Form
    {

        // a list of all available sessions
        public List<Session> lstAllSessions;
                    

        public Form1()
        {

            InitializeComponent();

            // call list<session> constructor
            lstAllSessions = new List<Session>();

            // when form constructer called, add example hard coded data into the list
            AddExampleData();

            // clear the onscreen results
            lbResults.Items.Clear();

            // loop through sessions and add them to onscreen results (default - so all sessions)
            foreach (Session s in lstAllSessions)
            {
                lbResults.Items.Add(s.ToString());
            }

            // load the combo box dynamically
            LoadComboBox();




        }

        // add example data into the list
        private void AddExampleData()
        {

            // set datetime to 2020/07/28 16:00:00
            DateTime dt1 = new DateTime(2020, 07, 28, 16, 0, 0);

            // call the cycling constructor
            Cycling s1 = new Cycling(101, "30 minute beach cycle", 30, 4, "Billy Robinson", "Flush out your legs and stay strong during this 30 minute cycle.", dt1, 300, 20);
            
            // add to the list of all sessions
            lstAllSessions.Add(s1);

            // repeat above with different data (hardcoded for now)

            DateTime dt2 = new DateTime(2020, 09, 28, 12, 0, 0);
            Cycling s2 = new Cycling(102, "60 minute chat 'n' Cycle", 60, 2, "Billy Robinson", "Chat whilst you cycle", dt2, 300, 25);
            lstAllSessions.Add(s2);

            DateTime dt3 = new DateTime(2020, 10, 28, 14, 0, 0);
            Cycling s3 = new Cycling(103, "120 minute hardcore cycle", 120, 10, "Billy Robinson", "The hardest cycling session ever", dt3, 400, 40);
            lstAllSessions.Add(s3);

            DateTime dt4 = new DateTime(2020, 11, 28, 20, 0, 0);
            Running s4 = new Running(104, "30 minute recovery run", 30, 2, "Kate Westbrooke", "Flush out your legs and stay strong during this 30 minute recovery run.", dt4, 20.1);
            lstAllSessions.Add(s4);

            DateTime dt5 = new DateTime(2020, 12, 28, 17, 0, 0);
            Running s5 = new Running(105, "60 minute Long distance run", 60, 7, "Billy Robinson", "Stretch your legs with this long distance run", dt5, 32.9);
            lstAllSessions.Add(s5);

            DateTime dt6 = new DateTime(2021, 1, 28, 22, 0, 0);
            Running s6 = new Running(106, "Overnight jog", 45, 3, "Billy Robinson", "Jog at night and relax", dt6, 12);
            lstAllSessions.Add(s6);
        }

        // load combo box data (selector of which type of session)
        private void LoadComboBox()
        {

            // create a new list to store the results (calls list constructor)
            List<string> sessionTypes = new List<String>();

            // for every session in all sessions, check to see if it's in the combo box
            foreach(Session thisSession in lstAllSessions)
            {

                // get the current type
                string s = thisSession.GetType().Name;

                // get the type of the parent
                string baseType = thisSession.GetType().BaseType.Name;

                // check if session type is already in combo box
                if(!sessionTypes.Contains(s))
                {
                    // if not, add it
                    sessionTypes.Add(s);
                }

                // check if the base is on the list
                if (!sessionTypes.Contains(baseType))
                {
                    // if not, add it
                    sessionTypes.Add(baseType);
                }

            }

            // set datasource to the list of types of sessions
            cboSelector.DataSource = sessionTypes;

        }

        // when combo box option changed, is called.
        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear the onscreen list of sessions
            lbResults.DataSource = null;
            lbResults.Items.Clear();

            // loop through the session objects
            foreach (var i in lstAllSessions)
            {
                // if the session object is the selected item, throw on screen
                if(i.GetType().Name == cboSelector.SelectedItem.ToString())
                {
                    // add it to the list box on screen
                    lbResults.Items.Add(i);
                }

                // check if the basetype is equal to the selected
                else if (i.GetType().BaseType.Name == cboSelector.SelectedItem.ToString())
                {
                    // add it to the list box on screen
                    lbResults.Items.Add(i);
                }
            }


        }
    }
}
