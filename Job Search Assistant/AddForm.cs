using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Search_Assistant
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ApplicationModel jobApplication = new ApplicationModel(
                    companyNameText.Text, 
                    jobLocationText.Text, 
                    jobTitleText.Text, 
                    DateTime.Now, 
                    true);
                if (urlLabel.Text != "")
                {
                    jobApplication.appPageURL = urlText.Text;
                }                
                GlobalConfig.Connection.CreateJobApplication(jobApplication);
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
