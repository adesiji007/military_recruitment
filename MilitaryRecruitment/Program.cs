using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryRecruitment
{
   static class Program
    {
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // instantiate a ApplicantList objects
           ApplicantList applicantList = new ApplicantList();

           // Instantiate a ForceServiceList object
           ForceServiceList forceServiceList = new ForceServiceList();

           // Instantiate a text report generator
           TextReportGenerator trg = new TextReportGenerator();
           // instantiate a SerializeFileHandler object, to make argument to Run()

           SerializeFileHandler sfh = new SerializeFileHandler();

           SplashForm loader = new SplashForm();
           loader.ShowDialog();

           Application.Run(new FormBasedUI(applicantList, forceServiceList, trg, sfh));

        }
    }
}
