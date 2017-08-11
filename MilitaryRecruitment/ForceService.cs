using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    public class ForceService : IDisplay
    {
        // property for the ForceSercive objects
        public string FSNo { get; set; }
        public string FSProgram { get; set; }
        public string FSCoordinator { get; set; }
        public string FSCredits { get; set; }
        public string FSEmailaddress { get; set; }

        // using Dictionary for enrolled Military Recruitment applicant
        public Dictionary<string, Applicant> EnrolledApplicants { get; set; }

        // using Dictionary for storing ResultEntry
        public Dictionary<Applicant, ResultInput> GradeArchive { get; set; }

        // Constructor
        public ForceService(string fFSNo, string fFSProgram, string fFSCoordinator, string fFSCredits, string fFSEmailaddress)
        {
            FSNo = fFSNo;
            FSProgram = fFSProgram;
            FSCoordinator = fFSCoordinator;
            FSCredits = fFSCredits;
            FSEmailaddress = fFSEmailaddress;

            // Result empty Dictionary object
            EnrolledApplicants = new Dictionary<string, Applicant>();
            GradeArchive = new Dictionary<Applicant, ResultInput>();
        }

        // Return applicant FSNo and FSProgram
        public override string ToString()
        {
            return String.Format("{0} {1}", FSNo, FSProgram);
        }
        // Return a formatted string of all data
        public string Display(string nType)
        {
            string msg;
            string CR = Environment.NewLine;

            msg = String.Format("\nForceService information {0}", CR);
            msg += String.Format("   FSNo: {0} {1}", FSNo, CR);
            msg += String.Format("   FSProgram: {0} {1}", FSProgram, CR);
            msg += String.Format("   FSCoordinator: {0} {1}", FSCoordinator, CR);
            msg += String.Format("   FSCredit: {0} {1}", FSCredits, CR);
            msg += String.Format("   FSEmailaddress: {0} {1}", FSEmailaddress, CR);

            // Display all the Applicant that applied for the military force

            msg += DisplayEnrolledApplicants();/// summary>
            /// call the appropriate methods to get the input data
            /// </summary>
           
            msg += String.Format("----------------------------");
            return msg;
        }
        // Return a formatted string containing all enrolled Applicant
        public string DisplayEnrolledApplicants()
        {
            string msg;
            string CR = Environment.NewLine;

            msg = String.Format(" {0} Enrolled Applicant = {1} {2}", CR, EnrolledApplicants.Count, CR);
            foreach (KeyValuePair<string, Applicant> kv in EnrolledApplicants)
            {
                Applicant a = kv.Value;
                msg += String.Format(" {0} {1} {2}", a.RegNo, a.Name, CR);

            }
            return msg;
        }

        // Enrol an Applicant into Millitary forces
        public void Enrol(Applicant applicant)
        {
            // check for the information about the applicant
            //about if they have already applied
            if (GradeArchive.ContainsKey(applicant))
            // enrolled 
            {
                AlreadyPassedException apException = new AlreadyPassedException(applicant.RegNo);
                throw (apException);
            }
            else
            {
                // Add Applicant to the Dictionary
                EnrolledApplicants.Add(applicant.RegNo, applicant);
                // Add to ForceService
                applicant.AddForceService(this);
            }
        }
        // Unenrol an applicant for a military force
        public void Unenrol(Applicant applicant)
        {
            // check for applicant enrolment
            if (GradeArchive.ContainsKey(applicant) == true) // passed
            {
                AlreadyPassedException apException = new AlreadyPassedException(applicant.RegNo);
                throw (apException);
            }
            else if (EnrolledApplicants.ContainsKey(applicant.RegNo) == false) // not currently enrolled
            {
                NotEnrolledException neException = new NotEnrolledException(applicant.RegNo);
                throw (neException);
            }
            else
            {
                // Remove Student from currentlyEnrolled dictionary
                EnrolledApplicants.Remove(applicant.RegNo);
                // Get the Applicant to remove Service from its 'enrolled' list
                applicant.DropForceService(this);
            }
            
        }

        // Set a grade for a currently enrolled applicant
        public void EnterMark(Applicant applicant, int mark)
        {
            // Check for errors before entering a grade
            // Applicant may have already passed exam or not be enrolled on it

            if (GradeArchive.ContainsKey(applicant) == true) //passed, so not currrently enrolled
            {
                AlreadyPassedException apException = new AlreadyPassedException(applicant.RegNo);
                throw (apException);
            }
            else if (EnrolledApplicants.ContainsKey(applicant.RegNo) == false) //not currently enrolled
            {
                NotEnrolledException neException = new NotEnrolledException(applicant.RegNo);
                throw (neException);
            }
            else
            {
                // Add Applicant to the Dictionary 
                EnrolledApplicants.Add(applicant.RegNo, applicant);

                // Get the Applicant to add this ForceService to its 'enrolled' List
                applicant.AddForceService(this);


                ResultInput ri = new ResultInput(this, applicant, mark);

                // If applicant has passed the exam
                if (mark >= AppData.PASSMARK)
                {
                    // Add the ResultInput and its associated Applicant 
                    // to the GradeArchive dictionary.
                    GradeArchive.Add(applicant, ri);

                    // Remove Applicant from the currentlyEnrolled dictionary
                    EnrolledApplicants.Remove(applicant.RegNo);

                    // Get the Applicant to remove Exam/ForceService course from its 'enrolled' list
                    applicant.DropForceService(this);
                }
            }
        }


    }
}























































































































