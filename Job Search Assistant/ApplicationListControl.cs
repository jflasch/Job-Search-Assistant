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
        private ApplicationModel model;
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

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement functionality for adding notes
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

        // TODO - Allow the control to be clicked on to bring up an edit screen.
    }
}
