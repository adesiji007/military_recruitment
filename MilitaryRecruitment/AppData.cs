using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    static class AppData
    {
        // Value required by application as a whole.
        // if the business rules change, requiring changes to this values
        // this is the only part of code that needs to be alter
 
        // Filenames for saving text report files
        public const string Applicants = "AllApplicants";
        public const string ForceServices = "AllForceServices";
        public const string DataFile = "MilitaryData";

        // Number of credits needed to get enter into the military recruitment
        public const int MAXCREDITS = 140;

        // Grade needed to pass a text for the Force Service
        public const int PASSMARK = 45;

        // TODO - Add filename for saving full MilitaryRecruitment data

    }
}
