using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    class NotEnrolledException : Exception
    {
        // When a user tries to either unenrol a Applicant 
        // or set a Applicant's mark 
        // for a ForceService on which they are not enrolled.
        private static string msg = " is not enrolled on this forceService";

        public NotEnrolledException(string RegNo)
            : base("Error: " + RegNo + msg)
        {

        }
    }
}
