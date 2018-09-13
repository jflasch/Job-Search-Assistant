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
        private List<ApplicationModel> applicationModels = new List<ApplicationModel>();

        public ApplicationListControl()
        {
            InitializeComponent();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement functionality for adding notes
        }

        private void urlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // If a url exists for this application, open it
            if (urlHiddenLabel.Text != "")
            {
                System.Diagnostics.Process.Start(urlHiddenLabel.Text);
            }
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            LoadListData();
            ApplicationModel currentModel = new ApplicationModel();

            // Find the current model
            foreach (ApplicationModel model in applicationModels)
            {
                if (model.Id.ToString() == this.Tag.ToString())
                {
                    currentModel = model;
                    break;
                }
            }
            
            // Switch the status of the application and update the view of the control
            if (statusLabel.Text == "Open")
            {
                statusLabel.Text = "Closed";
                statusLabel.ForeColor = Color.Red;
                this.BackColor = Color.LightSalmon;
                // not sure if i even need this line
                currentModel.status = false;
                GlobalConfig.Connection.EditStatus(currentModel.Id);
            } else
            {
                statusLabel.Text = "Open";
                statusLabel.ForeColor = Color.Green;
                this.BackColor = Color.White;
                currentModel.status = true;
                GlobalConfig.Connection.EditStatus(currentModel.Id);
            }


        }
        private void LoadListData()
        {
            applicationModels = GlobalConfig.Connection.GetApplicationModels_All();
        }

        // TODO - Allow the control to be clicked on to bring up an edit screen.
    }
}
