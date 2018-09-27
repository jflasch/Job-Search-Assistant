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
    public partial class EditForm : Form
    {
        private ApplicationModel model;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(ApplicationModel model)
        {
            InitializeComponent();
            this.model = model;
            companyNameText.Text = model.companyName;
            jobTitleText.Text = model.jobTitle;
            jobLocationText.Text = model.jobLocation;
            applyDateDateTimePicker.Value = model.dateApplied;
            urlText.Text = model.appPageURL;
            notesText.Text = model.notes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                model.companyName = companyNameText.Text;
                model.jobTitle = jobTitleText.Text;
                model.jobLocation = jobLocationText.Text;
                model.dateApplied = applyDateDateTimePicker.Value;
                model.appPageURL = urlText.Text;
                model.notes = notesText.Text;
                GlobalConfig.Connection.Edit(model);
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
