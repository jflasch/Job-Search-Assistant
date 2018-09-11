using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace Job_Search_Assistant
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ApplicationModel jobApplication = new ApplicationModel(
                    companyNameText.Text, 
                    jobLocationText.Text, 
                    jobTitleText.Text, 
                    applyDateDateTimePicker.Value, 
                    true);
                if (urlLabel.Text != "")
                {
                    jobApplication.appPageURL = urlText.Text;
                }                
                GlobalConfig.Connection.CreateJobApplication(jobApplication);
                this.Close();
            }
        }
        
        private bool ValidateForm()
        {
            if (companyNameText.Text == "" || jobLocationText.Text == "" || jobTitleText.Text == "")
            {
                errorLabel.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
