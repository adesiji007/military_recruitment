using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    public class Applicant : IDisplay
    {
        // auto implement property
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Address{get; set;}
        public string ProgramApplied { get; set; }
        public string EmailAddress { get; set; }

        // declare the reference for each Applicant and determine the applicanr registration.
        public List <ForceService> EnrolledOn {get; set;}

        // Declare a reference to this Applicant's result
        public Result Result { get; protected set; }

        // Constructor
        public Applicant (string regNo, string name,  string address, string progApplied, string emailAddress )
        {
           RegNo = regNo;
           Name = name;
           ProgramApplied = progApplied;
           Address = address;
           EmailAddress = emailAddress;

        // Creat an empty List
        EnrolledOn = new List<ForceService>();

        // form and creat a Result and link it to the Applicant
        Result = new Result(this);
        }
        // Return RegNo and Name for every single Applicant
        public override string ToString()
        {
 	
            return string.Format("{0} {1}", RegNo, Name);
        }
        // Return a formatted string containing all applicant data
       

        public string Display(string nType)
        {
            string msg;
            string CR = Environment.NewLine;

            msg = String.Format("Applicant: {0} {1}", RegNo, CR);
            msg += String.Format("  Name: {0} {1}", Name, CR);
            msg += String.Format("  Address: {0} {1}", Address, CR);
            msg += String.Format("  ProgramApplied: {0} {1}", ProgramApplied, CR);
            msg += String.Format("  EmailAddress: {0} {1}", EmailAddress, CR);

            // Display ForceServices for which the Applicant has enrolled
            msg += DisplayEnrolledForceServices();

            //Display the Applicant's Result
            msg += Result.Display();

            msg += String.Format("-----------------------------------{0}", CR);
            return msg;
        }

        // Add ForceService to List Applicant's result
        public void AddForceService(ForceService forceService)
        {
            EnrolledOn.Add(forceService);
        }
        // Remove forceService from attends List. Applicant has either
        // passed the forceService or has unenrolled from it
        public void DropForceService(ForceService forceService)
        {
            EnrolledOn.Remove(forceService);
        }

        // Return a formated string containing all Forces that applicant is applied to
        public string DisplayEnrolledForceServices()
        {
            string msg;
            string CR = Environment.NewLine;

            msg = String.Format("{0} Enrolled on: {1}", CR, CR);
            if (EnrolledOn.Count == 0)
            {
                msg += String.Format(" No ForceService listed {0}", CR);
            }
            else
            {
                foreach (ForceService s in EnrolledOn)
                {
                    msg += String.Format(" {0}  {1}", CR);
                }
            }
            return msg;
        }

    }
}
