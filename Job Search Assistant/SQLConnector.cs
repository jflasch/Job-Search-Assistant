using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make the CreateJobApplication actually save to the database
        /// <summary>
        /// Saves a new job application to the database
        /// </summary>
        /// <param name="model">The application information</param>
        /// <returns>The application information, including the unique identifier</returns>
        public ApplicationModel CreateJobApplication(ApplicationModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
