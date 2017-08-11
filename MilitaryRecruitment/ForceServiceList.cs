using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryRecruitment
{
    [Serializable]
    public class ForceServiceList : IDisplay
    {
        // generic list of the forceservice officer
        public List<ForceService> ForceService;

        // Constructor
        public ForceServiceList()
        {
            ForceService = new List<ForceService>();
        }
        
        // Add new services to the list of all the officer
    // check if it has not been used
    public bool AddForceService(ForceService forceService)
    {
        bool success = true;
        foreach (ForceService s in ForceService)
        {
            if (s.FSNo == forceService.FSNo)
            {
                success = false;
            }

        }
        if (success)
        {
                ForceService.Add(forceService);
        }
        return success;
        
    }
        // find and return ForceService that matches the search

        public ForceService FineItem(string sFSNo)
    {
        ForceService forceService = null;
        foreach (ForceService s in ForceService )
            {
                    if (s.FSNo == sFSNo)
                        {
                             forceService = s;
                        }
            }
            return forceService;
    }
        
        // Return a formatted  string of force Services FSNo and FSProgram for
        // force service list
                    
            public string Display(string nType)
            {
                string msg;
                string CR = Environment.NewLine;

                msg = "ForceService" + CR;
                msg +="-----------------" + CR;
                foreach (ForceService s in ForceService)
                {
                     msg += String.Format("{0} {1}c{2}", s.FSNo, s.FSProgram, CR);
                }
                
                msg += CR + "No of items: " + ForceService.Count() + CR;
                return msg;
            }
       }
}
