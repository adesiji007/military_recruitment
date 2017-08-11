using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace MilitaryRecruitment
{
    public partial class FormBasedUI : Form, IUserInterface
    {

        ApplicantList applicantList;
        ForceServiceList forceServiceList;
        TextReportGenerator textReportGenerator;

        // Declare reference serialize file handler object
        SerializeFileHandler serializeFileHandler;


        #region ################ Setup #############

        // Include parameter for serialise file handler in Constructor

        /// <summary>
        /// Constructor for FormBasedUI
        /// </summary>
        /// <param name="app">applicantList object</param>
        /// <param name="ser">forceSreviceList object</param>
        /// <param name="trg">text report generator object</param>
        /// <param name="sfh">text report serialize object</param>
        public FormBasedUI(ApplicantList app, ForceServiceList ser, TextReportGenerator trg, SerializeFileHandler sfh)
        {
            InitializeComponent();
            applicantList = app;
            forceServiceList = ser;
            // Assign parameter textReport file handler object
            textReportGenerator = trg;
            // Assign parameter serilize file handler object
            serializeFileHandler = sfh;


        }

        /// <summary>
        /// initialisation - load data from external file
        /// or generate test data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormBasedUI_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to load data from file? ",
                     "Load data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LoadMFData();
            }
            else
            {
                GenerateTestData();
            }

            foreach (Applicant app in applicantList.Applicant)
            {
                cboApplicants.Items.Add(app);
                
            }
            foreach (ForceService ser in forceServiceList.ForceService)
            {
                
                cboForceServices.Items.Add(ser);
            }

        }
        /// <summary>
        /// Code which can be used to generate data for Military Recruitment if
        /// the data fill becomes lost or corrupted
        /// </summary>
        public void GenerateTestData()
        {
            // Instantiate Applicant object
            Applicant a1 = new Applicant("100", "Mamsol Riches", "AirForce Officer", "15 Riverside avenue dh4 5lm", " Mamsol.Riche@hotmail.com");
            Applicant a2 = new Applicant("300", "David Cameroon", "Army Cadet Officer", "27 Adelaide Avenu, Newcastle ne1 5tr", " David.Cameroon@yahoo.com");
            Applicant a3 = new Applicant("500", "Goodluck Jonathan", "AirForce Officer", "104 Port arthur road, Nothingham ng2 4lt", " Goodluck.Jonathan@hotmail.com");
            Applicant a4 = new Applicant("700", "Richard Mark", "Naval Force Officer", "11 Macdonals street, Hartlepool ts26 5rm ", " Richard.Mark@yahoo.com");
            Applicant a5 = new Applicant("900", "Solomon Olutunde", "AirForce supretendent Officer", "301 ramson Noal Road, Surerest Sunderland sr2 6de", " Solomon.Olutunde@yahoo.com");
            Applicant a6 = new Applicant("1900", "Okonko Malik", "Army Officer", "101 Julios Mountain Avenue, London se18 6dy", " Okonko.Malik@yahoo.com");
            Applicant a7 = new Applicant("3200", "Janet Laurell", "Naval Force supretendent Officer", "301 ramson Noal Road, Surerest Sunderland sr2 6de", " Janet.Laurell@hotmail.com");
            Applicant a8 = new Applicant("1100", "Write Harmmer", "AirForce supretendent Officer", "3003 ramson Lord Road, Surerest Sunderland sr17 9de", " Write.Harmmer@hotmail.com");
            Applicant a9 = new Applicant("2300", "John Kerry", "Army Officer  Officer", "277 Malifax Addex Road, Surerest Sunderland sr22 8ae", " John.Kerry@yahoo.com");

            applicantList.AddApplicant(a1);
            applicantList.AddApplicant(a2);
            applicantList.AddApplicant(a3);
            applicantList.AddApplicant(a4);
            applicantList.AddApplicant(a5);
            applicantList.AddApplicant(a6);
            applicantList.AddApplicant(a7);
            applicantList.AddApplicant(a8);
            applicantList.AddApplicant(a9);

            // Instantiate ForceService object

            ForceService s1 = new ForceService("MR1001", "Logical Reasoning", " 30 ", "Right Philip", " right.philip@yahoo.com");
            ForceService s2 = new ForceService("MR1002", "Abstract Reasoning", "60", "James Cook", " James.Cook@yahoo.com");
            ForceService s3 = new ForceService("MR1004", "Running Exercise", "40", "Tommy Jerry", "Tommy.Jerry@yahoo.com");
            ForceService s4 = new ForceService("MR1006", "Communication Test", "60", "Lord Luggard", "Lord.Luggard@yahoo.com");
            ForceService s5 = new ForceService("MR1008", "Swimming Skill Test", "40", "Deep.Seewood", "Deep.Seewood@yahoo.com");
            ForceService s6 = new ForceService("MR2009", "Long Walk Test", "20", "Maggic Johnson", "Maggic.Johnson@yahoo.com");
            ForceService s7 = new ForceService("MR2005", "Road Mapping Test", "40", "Marggor Lyrics", "Marggor.Lyrics@yahoo.com");
            ForceService s8 = new ForceService("MR2007", "GIS Management", "20", "Manny Lorrell", "Manny.Lorrell@yahoo.com");
            ForceService s9 = new ForceService("MR2008", "GIS Management", "20", "Danny Maxorrell", "Manny.Lorrell@yahoo.com");

            forceServiceList.AddForceService(s1);
            forceServiceList.AddForceService(s2);
            forceServiceList.AddForceService(s3);
            forceServiceList.AddForceService(s4);
            forceServiceList.AddForceService(s5);
            forceServiceList.AddForceService(s6);
            forceServiceList.AddForceService(s7);
            forceServiceList.AddForceService(s8);
            forceServiceList.AddForceService(s9);


            // Enrol some Applicant into the Military Recruitment Force Services
            s1.Enrol(a1);
            s2.Enrol(a1);
            s3.Enrol(a1);

            s2.Enrol(a2);
            s3.Enrol(a2);
            s4.Enrol(a2);

            s5.Enrol(a3);
            s6.Enrol(a3);

            s5.Enrol(a4);
            s8.Enrol(a5);
            s2.Enrol(a7);

            s9.Enrol(a1);
            s1.Enrol(a9);
            s2.Enrol(a8);

            // Enter some Grade for Applicants on ForceService Examination
            s1.EnterMark(a1, 40);
            s2.EnterMark(a2, 30);
            s3.EnterMark(a3, 40);

        }
        #endregion

        #region ########## Form Code ##########
        private void applicantReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDisplay iDisp = (Applicant)cboApplicants.SelectedItem;
            GenerateTextReport(iDisp);
        }


        private void allApplicantsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateTextReport(applicantList);
        }


        private void allAllForceServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDisplay iDisp = (ForceService)cboForceServices.SelectedItem;
            GenerateTextReport(iDisp);
        }

        private void viewAllForceServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateTextReport(forceServiceList);
        }

        private void exitToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnEnterGrades_Click(object sender, EventArgs e)
        {
            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select the forceService and applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }
            else
            {
                //grpResultInput.Visible = true;
            }
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            //SetForceServiceMark();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save the data file? ",
                "Save data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SaveMFData();
            }
            Application.Exit();
        }



        private void lstApplicants_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDisplay applicant = (Applicant)GetItem(" A ");
            DisplayAll(applicant);
        }

        private void cboForceServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDisplay forceService = (ForceService)GetItem("F");
            DisplayAll(forceService);
        }

        private void addApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddApplicant();
        }

        private void addForceServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAll(applicantList);
        }
        private void successApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAll(applicantList);
        }




        private void exitToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       /* private void btnDisplaySucessful_Click(object sender, EventArgs e)
        {
        
        public void SucessfulApplicant(IDisplay iDisp)
        {
            string filename = "";
            if (iDisp == null)
            {
                MessageBox.Show("First select the Successfull Applicants to be sent to the report file");
            }
            else
            {
                if (iDisp is Applicant)
                {
                    Applicant a = (Applicant)iDisp;
                    filename = a.RegNo;
                }
                else if (iDisp is ForceService)
                {
                    ForceService s = (ForceService)iDisp;
                    filename = s.FSNo;
                }
                else if (iDisp is ApplicantList)
                {
                    filename = AppData.Applicants;
                }
                else
                {
                    filename = AppData.ForceServices;
                }
                textReportGenerator.GenerateReport(iDisp, filename + ".txt");
                MessageBox.Show("Text report " + filename + ".txt" + " created.");

            }
        }
    }*/

        /// <summary>
        /// Save all application data
        /// </summary>
        public void SaveMFData()
        {
            // Instantiate a MilitaryData object to hold all data
            MF mfFile = new MF();

            // Copy the application data into the militaryDatafile object
            mfFile.applicantList = applicantList;
            mfFile.fSList = forceServiceList;

            //Save MF file
            serializeFileHandler.SaveMFFile(mfFile, AppData.DataFile);

            MessageBox.Show("MF data file has been saved");
        }

  

        private void enterMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetServiceForceGrade();
            
        }

        public void SetServiceForceGrade()
        {
            Applicant app = (Applicant)cboApplicants.SelectedItem;
            MarkEntry mEntry = new MarkEntry(app);
            mEntry.ShowDialog();
        }
        

       

        private void enrolApplicantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show(" You must first select the ForceService and the Applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }

            else
            {
                EnrolApplicant();
            }


        }

        private void unenrolApplicantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show(" You must first select the ForceService and the Applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }

            else
            {
                UnenrolApplicant();
            }

        }

        private void unsucessfulApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show(" You must first select the ForceService and the Applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }

            else
            {
                //unsucessfulApplicant();
            }

        }

        private void sucessfulApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show(" You must first select the ForceService and the Applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }

            else
            {
                //sucessfulApplicant();
            }


        }

        
        private void exitMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select the forceService and applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }
            else
            {
                //grpMarkEntry.Visible = true;
            }
        }

        private void addNewApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDataForm newApplicant = new AddNewDataForm("A", applicantList, cboApplicants);
            newApplicant.ShowDialog();
        }

        private void viewAllApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public IDisplay GetItem(string sType)
        {
            IDisplay res;
            if (sType == "A")
            {
                Applicant app = (Applicant)cboApplicants.SelectedItem;
                res =  app;
            }

            else
            {
                ForceService fServe = (ForceService)cboForceServices.SelectedItem;
                res = fServe;
            }

            return res;
        }

        public void DisplayAll(IDisplay displayObject)
        {
            if (displayObject is ApplicantList == true)
            {
                cboApplicants.Items.Clear();
                foreach (Applicant a in applicantList.Applicant)
                {
                    cboApplicants.Items.Add(a);
                }
            }
            else if (displayObject is ForceServiceList == true)
            {
                cboForceServices.Items.Clear();
                foreach (ForceService s in forceServiceList.ForceService)
                {
                    cboForceServices.Items.Add(s);
                }
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.Text = displayObject.Display("A");
            }
        }



        #endregion

        #region ############ IUserInterface methods  ###########

        /// <summary>
        /// Search for Applicant or ForceService object from the collection and return it
        /// </summary>
        /// <param name="sType">a string represent the search term</param>
        /// <returns> an object of type IDisplay</returns>

        /// <summary>
        /// Display formatted data for the object passed in as parameter
        /// </summary>
        /// <param name="displayObject">an object of type IDisplay</param>


        /// <summary>
        /// Add new Student to the system
        /// </summary>
        public void AddApplicant()
        {
            //Open new form to input student's data
            AddNewDataForm addForm = new AddNewDataForm("applicant", applicantList, cboApplicants);
            addForm.ShowDialog();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Get new applicant data from second form
                //Applicant newApplicant = addForm.GetApplicantData();

                //Add new applicant to applicant list
                bool success = applicantList.AddApplicant(newApplicant);
                if (success)
                {
                    MessageBox.Show(newApplicant.RegNo + " has been added to the list");
                    //redisplay list of Applicants
                    DisplayAll(applicantList);

                    // Display new applicant 
                    txtDisplay.Clear();
                    //txtDisplay.Text = newApplicant.Display();
                }
                else
                {
                    MessageBox.Show("\nUnable to add. This applicant RegNo already been used");
                }

            }
        }

        private void enrolApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select the forceService and applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }
            else
            {
                EnrolApplicant();
            }
        }

        private void unenrolApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select the module and student");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }
            else
            {
                UnenrolApplicant();
            }
        }
        

        /// <summary>
        /// Add new ForceService to the system
        /// </summary>
        public void AddServiceForce()
        {
            //Open new form to input ForceService's data
            AddNewDataForm addForm = new AddNewDataForm("forceService");
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Get new forceService data from second form
                ForceService newForceService = addForm.GetForceServiceData();

                //Add new forceService to forceService list
                bool success = forceServiceList.AddForceService(newForceService);
                if (success)
                {
                    MessageBox.Show(newForceService.FSNo + " has been added to the list");
                    //redisplay list of ForceServices
                    DisplayAll(forceServiceList);

                    // Display new forceService 
                    txtDisplay.Clear();
                    //txtDisplay.Text = newForceService.Display();
                }
                else
                {
                    MessageBox.Show("\nUnable to add. This forceService FSNo already been used");
                }

            }
        }

        /// <summary>
        ///  Enrol Applicant onto a particular ForceService
        /// </summary>
        public void EnrolApplicant()
        {
            // Get selected Applicant and ForceService
            ForceService forceService = (ForceService)cboForceServices.SelectedItem;
            Applicant applicant = (Applicant)cboApplicants.SelectedItem;

            try
            {
                // Enrol this Applicant onto this ForceService
                DialogResult dr = MessageBox.Show("Enrol " + applicant.RegNo + " onto " + forceService.FSNo + "?", "Enrol",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    forceService.Enrol(applicant);
                    MessageBox.Show("Succcesful enrolment");
                    txtDisplay.Clear();
                    //txtDisplay.Text = applicant.Display();
                    //txtDisplay.Text = forceService.Display();
                }
            }

            // Catch exceptions if student already enrolled or already passed module
            catch (AlreadyEnrolledException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AlreadyPassedException ap)
            {
                MessageBox.Show(ap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Unenrol a Applicant from a ForceService
        /// </summary>
        public void UnenrolApplicant()
        {
            // Get selected Applicant and ForceService
            ForceService forceService = (ForceService)cboForceServices.SelectedItem;
            Applicant applicant = (Applicant)cboApplicants.SelectedItem;

            try
            {
                DialogResult dr = MessageBox.Show("Unenrol " + applicant.RegNo + " from " + forceService.FSNo + "?", "Enrol",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    // Unenrol the Applicant from this ForceService program
                    forceService.Unenrol(applicant);

                    MessageBox.Show("Succcesful unenrolment");
                    txtDisplay.Clear();
                    //txtDisplay.Text = applicant.Display();
                    //txtDisplay.Text = forceService.Display();
                }
            }

            // catch exceptions if applicant not enrolled or already passed exam for ForceService
            catch (NotEnrolledException ne)
            {
                MessageBox.Show(ne.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AlreadyPassedException ap)
            {
                MessageBox.Show(ap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Create a text file containing formatted output
        /// </summary>
        /// <param name="iDisp">an object of type IDisplay</param>
        public void GenerateTextReport(IDisplay iDisp)
        {
            string filename = "";

            if (iDisp == null)
            {
                MessageBox.Show("First select the item to be sent to the report file", "No item selected");
            }
            else
            {
                if (iDisp is Applicant)
                {
                    Applicant a = (Applicant)iDisp;
                    filename = a.RegNo;
                }
                else if (iDisp is ForceService)
                {
                    ForceService s = (ForceService)iDisp;
                    filename = s.FSNo;
                }
                else if (iDisp is ApplicantList)
                {
                    filename = AppData.Applicants;
                }
                else
                {
                    filename = AppData.ForceServices;
                }
                textReportGenerator.GenerateReport(iDisp, filename + ".txt");
                MessageBox.Show("Text report " + filename + ".txt" + " created.");
            }
        }


      

        /// <summary>
        /// Load the mf data file
        /// </summary>
        public void LoadMFData()
        {
            // Make sure the file mf.data has been created and exists 
            // in the bin\debug folder of this project.
            try
            {
                // Instantiate a MF object to hold all data
                MF mfFile = new MF();

                // Deserialize the file into the MF object
                mfFile = serializeFileHandler.LoadMFFile(AppData.DataFile);

                // Copy the data back into the two lists
                applicantList = mfFile.applicantList;
                forceServiceList = mfFile.fSList;
                MessageBox.Show("MF data file has been loaded");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private void addNewApplicantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddApplicant();
        }

        private void addNewForceServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //AddForceService();
        }

        private void viewAllForceServiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //DisplayAll(ForceService);
        }

        private void viewAllApplicantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             //DisplayAll(Applicant);
        }

        private void addNewForceServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddServiceForce();
        }

        private void exitMarkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            Applicant tempApp = null;
            if (cboForceServices.SelectedIndex == -1 || cboApplicants.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select the forceService and applicant");
                DisplayAll(forceServiceList);
                DisplayAll(applicantList);
            }
            else
            {
                foreach (Applicant app in applicantList.Applicant)
                {
                    if (app.Display("A") == cboApplicants.SelectedText)
                    {
                        tempApp = app;
                    }

                    MarkEntry mk = new MarkEntry(tempApp);
                    mk.ShowDialog();
                }
            }
        }

        public Applicant newApplicant { get; set; }
    }

    }

    

        #endregion




