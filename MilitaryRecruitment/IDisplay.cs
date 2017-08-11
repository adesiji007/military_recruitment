using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    public interface IDisplay
    {
        // interface is implementing Applicant, Applicantlist, ServiceForce, ServiveForce
        //this display the method for each display
        string Display(string sType);
    }
}
