using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    class EmailService
    {
        public void NotifyAllPlayTimeUsed(string emailAddress)
        {
            // Simulates the idea of sending an email.
            // FYI: if you wish to try to properly send an email from your code then look at the 
            // System.Net.Mail and System.Net libraries. These contain suitable classes to construct
            // and send email. You will, however, require access to a mail server through a valid account.
            // Experience of this has shown that using the University mail server does not work so be
            // warned (you will probably need access to a mail server of your own, maybe from a hosting
            // service you have with your ISP). If none of this makes sense, then it is probably best
            // leaving alone.
            Console.WriteLine(String.Format("\n\nEmail sent to address [{0}] notifying that all play time has been used!", emailAddress));
        }
    }
}
