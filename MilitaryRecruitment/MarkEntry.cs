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
    public partial class MarkEntry : Form
    {
        Applicant app;
        public MarkEntry(Applicant app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void MarkEntry_Load(object sender, EventArgs e)
        {
        }

        /* private void btnEnterMark_Click(object sender, EventArgs e)
         {

             if(lstForceServices.SelectedIndex == -1 || Applicants.SelectedItem == -1)
             {
                 MessageBox.Show("You must select the FirstService and Applicant");
                 DisplayAll(ForceServiceList);
                 DisplayAll(ApplicantList);
             }
             else
             {
                 listBox1.Visible = true;
             }
         }

         private void btnSaveMark_Click(object sender, EventArgs e)
         {
             SetForceServiceMark();
         }
     }
 */
    }
}
