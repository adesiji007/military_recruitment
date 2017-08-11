using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryRecruitment
{
    public partial class AddNewDataForm : Form
    {
        string newType;
        ApplicantList apps = null;
        ComboBox appList = null;
        private string p;

        public AddNewDataForm(string nType, ApplicantList apps, ComboBox appList)
        {
            InitializeComponent();
            newType = nType;
            this.apps = apps;
            this.appList = appList;
        }

        public AddNewDataForm(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        /// <summary>
        /// load data into visual controls depending on input paramenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void AddNewDataForm_Load(object sender, EventArgs e)
        {
            if (newType == "applicant")
            {
                lblTitle.Text = "New Applicant";
                lblFirst.Text = "Applicant RegNo:";
                lblSecond.Text = "Applicant Name: ";
                lblThird.Text = "ProgramApplied: ";
                lblFourth.Text = "Applicant Address: ";
                lblFive.Text = " EmailAddress: ";


            }
            else
            {
                lblTitle.Text = "New ForceService";
                lblFirst.Text = "ForceServive FSNo";
                lblSecond.Text = "ForceService FSProgram";
                lblThird.Text = "FSCoordinate";
                lblFourth.Text = "number of FSCredit";
                lblFive.Text = "FSEmailaddress";

            }

            

        }
        /// summary>
        /// call the appropriate methods to get the input data
        /// </summary>
           
        private void btnOK_Click(object sender, EventArgs e)

        {
            if(newType == "applicant")
            {
                GetApplicantData();
            }
            else
            {
                GetForceServiceData();
            }
        
        }
        /// <summary>
        /// Get data from visual controls and instantiates a ne Applicant object
        /// </summary>
        /// <returns> a Applicant object</returns>
        public void GetApplicantData()
        {
            Applicant newApplicant = new Applicant(txtFirst.Text, txtSecond.Text, txtThird.Text, txtFourth.Text, txtFive.Text);
            apps.AddApplicant(newApplicant);
            RefreshList();
            //return newApplicant;
        }
        /// <summary>
        /// Get data from visual controls and instantiates a new ForceService object
        /// </summary>
        /// <returns> a ForceService object</returns>
        
        public ForceService GetForceServiceData()
        {
            ForceService newForceService = new ForceService(txtFirst.Text, lblSecond.Text, lblThird.Text, txtFourth.Text, txtFive.Text);
            return newForceService;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshList()
        {
            appList.Items.Clear();
            foreach(Applicant a in apps.Applicant)
            {
                appList.Items.Add(a.ToString());
            }
        }

       
    }
}
