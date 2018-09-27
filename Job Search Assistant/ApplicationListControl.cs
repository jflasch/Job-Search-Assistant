using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Search_Assistant
{
    public partial class ApplicationListControl : UserControl
    {
        public ApplicationModel model;
        private ApplicationsListForm parentForm;

        public ApplicationListControl()
        {
            InitializeComponent();
        }

        public ApplicationListControl(ApplicationModel model, ApplicationsListForm parentForm)
        {
            InitializeComponent();
            this.model = model;
            this.parentForm = parentForm;
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            
            // Switch the status of the application and update the view of the control
            if (statusLabel.Text == "Open")
            {
                statusLabel.Text = "Closed";
                statusLabel.ForeColor = Color.Red;
                this.BackColor = Color.LightSalmon;
                // not sure if i even need this line
                model.status = false;
                GlobalConfig.Connection.EditStatus(model.Id);
            } else
            {
                statusLabel.Text = "Open";
                statusLabel.ForeColor = Color.Green;
                this.BackColor = Color.White;
                model.status = true;
                GlobalConfig.Connection.EditStatus(model.Id);
            }
            parentForm.CalculateStatistics();
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void urlLinkButton_Click(object sender, EventArgs e)
        {
            // If a url exists for this application, open it
            if (urlHiddenLabel.Text != "")
            {
                System.Diagnostics.Process.Start(urlHiddenLabel.Text);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you would like to delete this application?";
            string caption = "Delete Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                GlobalConfig.Connection.DeleteJobApplication(model.Id);
                parentForm.RemoveControl(this);
            }
            
        }
    }
}
