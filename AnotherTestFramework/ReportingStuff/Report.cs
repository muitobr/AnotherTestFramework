﻿using System;
using System.Collections.Generic;
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
            date = DateTime.Now;
            fileName = date.Date.Date.ToShortDateString() + date.TimeOfDay.Hours.ToString() + date.TimeOfDay.Minutes.ToString();
            path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            actualPath = path.Substring(0, path.LastIndexOf("bin"));
            projectPath = new Uri(actualPath).LocalPath;
            filePath = projectPath + "Reports\\" + fileName + ".csv";
            reportcsv = new StringBuilder();
            CreateCsvFile();

        }
        private void CreateCsvFile()
        {
            reportcsv.Append("StepDescription,");
            reportcsv.Append("Pass/Fail,");
            reportcsv.Append("Exception");
            File.AppendAllText(filePath, reportcsv.ToString());
        }
        public void AddLine(string description, string result, string exception)
        {
            reportcsv.Append(Environment.NewLine);
            reportcsv.Append(description + ",");
            reportcsv.Append(result + ",");
            reportcsv.Append(exception + ",");
            reportcsv.Append(Environment.NewLine);
            File.WriteAllText(filePath, reportcsv.ToString());
        }
    }
}
