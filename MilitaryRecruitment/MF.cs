using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    public class MF
    {
        public ApplicantList applicantList { get; set; }
        public ForceServiceList fSList { get; set; }
    }
}
