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
        private ApplicationsListForm parentForm;

        public AddForm()
        {
            InitializeComponent();
            applyDateDateTimePicker.Value = DateTime.Now;
        }

        public AddForm(ApplicationsListForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            applyDateDateTimePicker.Value = DateTime.Now;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // If the form is validated, create a new job application and place it in the SQL database
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
                parentForm.newModel = jobApplication;
                this.Close();                
            }
        }
        
        /// <summary>
        /// Check that all mandatory fields are filled in with text
        /// </summary>
        /// <returns></returns>
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
