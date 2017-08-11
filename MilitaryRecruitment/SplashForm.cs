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
    public partial class SplashForm : Form
    {
        private void timer1_Tick(object sender, EventArgs e)
        {
            //close this form after the interval has timed out
            this.Close();
        }
        
        
        public SplashForm()
        {
            InitializeComponent();

        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {

            timer1.Dispose();
            
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
