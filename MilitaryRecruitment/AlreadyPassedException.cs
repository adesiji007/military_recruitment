using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    class AlreadyPassedException : Exception
    {
        // When the user tries to set a mark for an applicant on the Exams
        // for which they have already received a pass mark
        private static string msg = "has already passed this Exam for ForceService: ";

        public AlreadyPassedException(string RegNo)
            : base ("Error: " + RegNo + msg)
        {

        }
    }
}
