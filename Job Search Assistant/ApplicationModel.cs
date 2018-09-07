using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public class ApplicationModel
    {
        /// <summary>
        /// Represents this applications unique identifier to be used for database communication
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of the company that this application applies to
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// Represents the job title of this application
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        /// Represents the location of the position that this application applies to
        /// </summary>
        public string jobLocation { get; set; }

        /// <summary>
        /// Represents the URL of the application description page on the internet
        /// </summary>
        public string appPageURL { get; set; }

        /// <summary>
        /// Represents the date on which the user sent out this application
        /// </summary>
        public DateTime dateApplied { get; set; }

        /// <summary>
        /// Represents the current status of this application (open or closed)
        /// </summary>
        public bool status { get; set; }

        /// <summary>
        /// Represents the notes for this application (interviews pending, etc...)
        /// </summary>
        public string notes { get; set; }

        public ApplicationModel(string companyName, string jobLocation, string jobTitle, DateTime dateApplied, bool status)
        {
            this.companyName = companyName;
            this.jobLocation = jobLocation;
            this.jobTitle = jobTitle;
            this.dateApplied = dateApplied;
            this.status = status;
        }

        public ApplicationModel()
        {

        }
        
    }
}
