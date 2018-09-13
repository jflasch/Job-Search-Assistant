using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public class SQLConnector : IDataConnection
    {        
        /// <summary>
        /// Saves a new job application to the database
        /// </summary>
        /// <param name="model">The application information</param>
        /// <returns>The application information, including the unique identifier</returns>
        public ApplicationModel CreateJobApplication(ApplicationModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("JobApplications")))
            {
                var p = new DynamicParameters();
                p.Add("@CompanyName", model.companyName);
                p.Add("@JobTitle", model.jobTitle);
                p.Add("@JobLocation", model.jobLocation);
                p.Add("@AppPageURL", model.appPageURL);
                p.Add("@DateApplied", model.dateApplied);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spJobApplications_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public List<ApplicationModel> GetApplicationModels_All()
        {
            List<ApplicationModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("JobApplications")))
            {
                output = connection.Query<ApplicationModel>("dbo.spJobApplications_GetAll").ToList();
            }

            return output;
        }

        public void EditStatus(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("JobApplications")))
            {
                var p = new DynamicParameters();
                p.Add("@id", id);
                connection.Execute("dbo.spJobApplications_EditStatus", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
