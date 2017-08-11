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
    public partial class Enrol : Form
    {
        public Enrol()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
         if(txtFirst.Text == "")
         {
             //no name
         }
        }
    }
}
