using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    public class ApplicantList : IDisplay
    {
        // Generic List of Applicant
        public List<Applicant> Applicant;

        // Constructor

        public ApplicantList()
        {
            Applicant = new List<Applicant>();
        }
        // Add new Applicant to the list, make sure that the RegNo has not been used
        public bool AddApplicant (Applicant applicant)
        {
            bool success = true;
            foreach (Applicant a in Applicant)
            {
                if (a.RegNo == applicant.RegNo)
                {
                    success = false;
                }
            }
            if (success)
            {
                Applicant.Add(applicant);
            }
            return success;

        }

        // Find and return Applicant that matches the required items and return
        // if applicant object not found
        public Applicant FindItem(string searchRegNo)
        {
            Applicant applicant = null;
            foreach (Applicant a in Applicant)
            {
                if (a.RegNo == searchRegNo)
                {
                    applicant = a;
                }
            }
            return applicant;
        }

        // Return a RegNo and name of all the applicant
        public string Display(string nType)
        {
            string msg;
            string CR = Environment.NewLine;

            msg = "--------------APPLICANT LIST---------" + CR;
            msg += "-------------------------------------" + CR;

            foreach (Applicant a in Applicant)
            {
                msg += String.Format("{0} {1}{2}", a.RegNo, a.Name, CR);
            }

            msg += CR + "No. of items: " + Applicant.Count() + CR;
            return msg;
            
        }
    }
}
