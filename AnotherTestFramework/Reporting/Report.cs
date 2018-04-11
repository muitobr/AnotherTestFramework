using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTestFramework
{
    public class Report
    {
        private string BrowserType;
        private string url;
        private DateTime date;
        private FileStream fs;
        private StringBuilder reportcsv;
        private string path;
        private string actualPath;
        private string projectPath;
        private string fileName;
        private string filePath;

        public Report(string BrowserType, string url)
        {
            this.BrowserType = BrowserType;
            this.url = url;
            path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            actualPath = path.Substring(0, path.LastIndexOf("bin"));
            projectPath = new Uri(actualPath).LocalPath;
            filePath = $"{projectPath}\\TestReport\\";
  
            if (Directory.Exists(filePath))
            {
                fileName = $"{projectPath}\\TestReport\\{string.Format("Report{0:ddMMyyyy_HHmmsstt}.csv", DateTime.Now, CultureInfo.InvariantCulture)}";
            }
            else
            {
                Directory.CreateDirectory(filePath);
                fileName = $"{projectPath}\\TestReport\\{string.Format("Report{0:ddMMyyyy_HHmmsstt}.csv", DateTime.Now, CultureInfo.InvariantCulture)}";
            }

            reportcsv = new StringBuilder();
            CreateCsvFile();
        }

        private void CreateCsvFile()
        {
            reportcsv.Append("StepDescription,");
            reportcsv.Append("Pass/Fail,");
            reportcsv.Append("Exception");
            File.AppendAllText(fileName, reportcsv.ToString());
        }

        public void AddLine(string description, string result, string exception)
        {
            reportcsv.Append(Environment.NewLine);
            reportcsv.Append(description + ",");
            reportcsv.Append(result + ",");
            reportcsv.Append(exception + ",");
            reportcsv.Append(Environment.NewLine);
            File.WriteAllText(fileName, reportcsv.ToString());
        }
    }
}
