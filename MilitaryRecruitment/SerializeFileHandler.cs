using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace MilitaryRecruitment
{

   public class SerializeFileHandler
    {
        // Write the MilitaryRecruitment object containing the application data 
        // to a binary file, via serialisation.
        public void SaveMFFile(MF militaryData, string filePath)
        {
            FileStream outFile;
            BinaryFormatter bFormatter = new BinaryFormatter();

            // Ppen file for output
            outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            // Output object to file via serialization
            bFormatter.Serialize(outFile, militaryData);

            // Close file
            outFile.Close();
        }

        // Read the binary file containing the application data C:\Users\adesiji\Documents\Visual Studio 2013\Projects\MilitaryRecruitment\MilitaryRecruitment\SerializeFileHandler.cs
        // via serialisation into a MilitaryRecruitment object, and return it
        public MF LoadMFFile(String filePath)
        {
            FileStream inFile;
            BinaryFormatter bFormatter = new BinaryFormatter(); 
            MF militaryData = new MF();

            // Open file for input
            inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            // Obtain objects from file via serialization
            militaryData = (MF)bFormatter.Deserialize(inFile);

            inFile.Close();
            return militaryData;
         }
    }
}

