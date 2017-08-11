using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    public class Result
    {
        // Result determines the outcome of the applicants application into the military 
        // recruitment and a list of ResultList
        public Applicant ApplicantForm { get; set; }
        public List<ResultInput> ResultInputs { get; set; }

        // Constructor
        public Result(Applicant Applicant)
        {
            // Indicate the applicant form for the entries to the Military
            ApplicantForm = Applicant;

            // Show an empty list  of result input
            ResultInputs = new List<ResultInput>();
        }

        // Add the candidate grade to the result
        public void AddResultInput(ResultInput ri)
        {
            ResultInputs.Add(ri);
        }

        // Get the Mark achieved by the applicant for him to be admited
        // to the Military
        public int GetTotalGrade()
        {
            int Credits = 0;
            foreach(ResultInput ri in ResultInputs)
            {
                if (ri.Grade >= AppData.PASSMARK)
                {
                    Credits += Convert.ToInt32(ri.ForceService.FSCredits);
                }

            }
            return Credits;
        }

        // return the strings that containing all the Result data
        public string Display()
        {
            string msg;
            string CR = Environment.NewLine;

            msg = String.Format("{0} Applicant Result {1} ", CR, CR);

            // Be sure if the ResultInput is not entered yet
            if (ResultInputs.Count < 0)
            {
                msg += String.Format(" (no entries yet) {0}", CR);
            }
            else
            {
                foreach (ResultInput ri in ResultInputs)
                {
                    ForceService s = ri.ForceService;
                    msg += String.Format(" ForceService: {0} {1}", s.FSNo, CR);

                    msg += String.Format(" FSCredits: {0} {1}", s.FSCredits, CR);

                    // add the result passed to the Grade
                    if (ri.Grade >= AppData.PASSMARK)
                    {
                        msg += String.Format(" Mark: {0} *** Approved TO MILITARY SCHOOL**** {1}", ri.Grade, CR);

                    }
                    else
                    {
                        msg += String.Format(" Mark: {0} ** Fail ** {1}", ri.Grade, CR);
                    }
                }
                // collect and add the actual scores 
                msg += String.Format(" {0} Total mark earned: {1} {2} ", CR, GetTotalGrade(), CR);

            }
            // check to see the applicant have enough mark to proceed
            if (GetTotalGrade() >= AppData.MAXCREDITS)
            {
                msg += String.Format(" *** Applicant has bee Approved for Program *** {0}", CR);
            }
            return msg;

        }

    }
}
    