using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public class TextConnector : IDataConnection
    {
        private const string JobApplicationsFile = "JobApplications.csv";
        // TODO - make this method actually save to text files
        public ApplicationModel CreateJobApplication(ApplicationModel model)
        {
            // Load the text file and convert the text to List<ApplicationModel>
            List<ApplicationModel> jobApplications = JobApplicationsFile.FullFilePath().LoadFile().ConvertToApplicationModels();

            int currentId = 1;
            if (jobApplications.Count > 0)
            {
                currentId = jobApplications.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            jobApplications.Add(model);
            jobApplications.SaveToJobApplicationFile(JobApplicationsFile);

            return model;
        }
    }
}
