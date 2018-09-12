using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public interface IDataConnection
    {
        ApplicationModel CreateJobApplication(ApplicationModel model);

        List<ApplicationModel> GetApplicationModels_All();

        void EditStatus(int Id);
    }
}
