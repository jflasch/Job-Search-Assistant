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
            applyDateDateTimePicker.Value = DateTime.Now;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //string blah = "https:///stackoverflow.com/questions/4833111/insert-value-into-a-string-at-a-certain-position";
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
                    /*string sub1 = urlText.Text.Substring(0, 5);
                    if (sub1 == "https")
                    {
                        string sub2 = urlText.Text.Substring(6, urlText.Text.Length-6);
                        urlText.Text = urlText.Text.Substring(0, 6) + "/" + sub2;
                    }*/
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
