using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MilitaryRecruitment
{
    public class TextReportGenerator
    {
        public void GenerateReport(IDisplay obj, string filePath)
        {
            FileStream outFile;
            StreamWriter writer;

            outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(outFile);

            writer.WriteLine(obj.Display("A"));

            writer.Close();
            outFile.Close();
        }
    }
}
