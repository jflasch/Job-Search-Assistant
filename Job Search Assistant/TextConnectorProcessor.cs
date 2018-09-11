using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<ApplicationModel> ConvertToApplicationModels(this List<string> lines)
        {
            List<ApplicationModel> output = new List<ApplicationModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ApplicationModel app = new ApplicationModel();
                app.Id = int.Parse(cols[0]);

                // TODO - Fix the issue where Locations separated by commas are split up incorrectly
                app.jobLocation = cols[1];
                app.jobTitle = cols[2];
                app.companyName = cols[3];
                app.appPageURL = cols[4];
                app.dateApplied = Convert.ToDateTime(cols[5]);
                if (cols[6] == "0")
                {
                    app.status = false;
                } else
                {
                    app.status = true;
                }
                app.notes = cols[7];

                output.Add(app);
            }
            return output;
        }

        public static void SaveToJobApplicationFile(this List<ApplicationModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (ApplicationModel app in models)
            {
                lines.Add($"{ app.Id },{ app.jobLocation },{ app.jobTitle },{ app.companyName },{ app.appPageURL },{ app.dateApplied.ToString() },{ app.status },{ app.notes }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
