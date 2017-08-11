using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    // serializable objects
   public class ResultInput
    {
       public ForceService ForceService { get; set; }
       public int Grade { get; set; }

       public ResultInput(ForceService forceService, Applicant applicant, int grade )
       {
           ForceService = forceService;
           Grade = grade;
           // Any grade archieved must be noted and added to the grade
           applicant.Result.AddResultInput(this);
       }
    }
}
