using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Search_Assistant
{
    public class TextConnector : IDataConnection
    {
        // TODO - make this method actually save to text files
        public ApplicationModel CreateJobApplication(ApplicationModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
