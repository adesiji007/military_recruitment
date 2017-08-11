using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    class AlreadyEnrolledException : Exception
    {
        // Information to supply to the applicant when they are already applied
        private static string msg = " Has already apply on the Service";

        public AlreadyEnrolledException(string RegNo)
            : base ("Error: " + RegNo + msg)
    {

    }
   }
}
