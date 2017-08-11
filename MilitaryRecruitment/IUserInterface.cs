using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    //method to implement this interface
    interface IUserInterface
    {
        IDisplay GetItem(string s);
        void DisplayAll(IDisplay obj);
        void AddApplicant();
        void AddServiceForce();

        void EnrolApplicant();
        void UnenrolApplicant();

        void GenerateTextReport(IDisplay obj);
        void SetServiceForceGrade();


        //Add function prototype for savings and loading MilitaryRecruitment Data
        void SaveMFData();
        void LoadMFData();
    }
}
