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
    public partial class ApplicationsListForm : Form
    {
        private List<ApplicationModel> applicationModels = new List<ApplicationModel>();
        private List<ApplicationListControl> applicationListControls = new List<ApplicationListControl>();
        private bool hideChecked = false;
        public ApplicationModel newModel;

        public ApplicationsListForm()
        {
            InitializeComponent();
            LoadListData();
            CreateControls();
            PopulateFlowLayout();
            CalculateStatistics();
        }

        /// <summary>
        /// Load all job applications from the database
        /// </summary>
        private void LoadListData()
        {
            applicationModels = GlobalConfig.Connection.GetApplicationModels_All();
        }

        /// <summary>
        /// Create a list of controls associated to all of the job applications
        /// </summary>
        private void CreateControls()
        {
            applicationListControls.Clear();
            foreach (ApplicationModel model in applicationModels)
            {
                ApplicationListControl aLC = CreateNewApplicationListControl(model);
                applicationListControls.Add(aLC);
            }
            sortControls();
        }

        /// <summary>
        /// Create an ApplicationListControl for each job application and add them to the flow layout
        /// </summary>
        private void PopulateFlowLayout()
        {
            applicationsListFlowLayout.SuspendLayout();
            applicationsListFlowLayout.Controls.Clear();
            applicationsListFlowLayout.Controls.AddRange(applicationListControls.ToArray());
            applicationsListFlowLayout.ResumeLayout();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            newModel = null;
            addForm.ShowDialog();
            if (newModel != null)
            {
                ApplicationListControl newControl = CreateNewApplicationListControl(newModel);
                for (int i = 0; i < applicationListControls.Count; i++)
                {
                    ApplicationListControl control = applicationListControls.ElementAt(i);
                    if (newControl.model.dateApplied.CompareTo(control.model.dateApplied) > 0)
                    {
                        applicationListControls.Insert(i, newControl);
                        break;
                    }
                }
                applicationModels.Add(newModel);
                PopulateFlowLayout();
                CalculateStatistics();
            }            
        }

        /// <summary>
        /// Sort the list of job applications by the given type
        /// </summary>
        /// <param name="sortType">Type by which the applications should be sorted</param>
        private void sortControls()
        {
            applicationListControls.Sort((x, y) => y.model.dateApplied.CompareTo(x.model.dateApplied));            
        }

        private void searchText_KeyUp(object sender, KeyEventArgs e)
        {
            
            applicationsListFlowLayout.SuspendLayout();
            string search = searchText.Text.ToLower();

            foreach (ApplicationListControl control in applicationsListFlowLayout.Controls)
            {
                string modelText = control.companyNameLabel.Text.ToLower() + " " + control.jobLocationLabel.Text.ToLower() + " " + control.jobTitleLabel.Text.ToLower();
                if (!modelText.Contains(search))
                {
                    control.Hide();
                } else if (modelText.Contains(search) && hideChecked && control.statusLabel.Text == "Closed")
                {
                    control.Hide();
                } else
                {
                    control.Show();
                }
                
            }
            applicationsListFlowLayout.ResumeLayout();
        }

        private void hideClosedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            applicationsListFlowLayout.SuspendLayout();
            if (hideClosedCheckBox.Checked)
            {
                hideChecked = true;
                foreach (ApplicationListControl control in applicationsListFlowLayout.Controls)
                {
                    if (control.statusLabel.Text == "Closed")
                    {
                        control.Hide();
                    }
                }
            } else
            {
                hideChecked = false;
                foreach (ApplicationListControl control in applicationsListFlowLayout.Controls)
                {
                    control.Show();
                }
            }

            applicationsListFlowLayout.ResumeLayout();
        }

        public void CalculateStatistics()
        {
            // Get the total number of applications
            totalApplicationsLabel.Text = "Total Applications: " + applicationModels.Count;

            // Get the number of open applications
            int openCount = 0;
            foreach (ApplicationModel model in applicationModels)
            {
                if (model.status)
                {
                    openCount++;
                }
            }
            openApplicationsLabel.Text = "Open Applications: " + openCount;
        }

        public void RemoveControl(ApplicationListControl control)
        {
            applicationListControls.Remove(control);
            applicationModels.Remove(control.model);
            applicationsListFlowLayout.Controls.Remove(control);
            CalculateStatistics();
        }

        private ApplicationListControl CreateNewApplicationListControl(ApplicationModel model)
        {
            ApplicationListControl aLC = new ApplicationListControl(model, this);
            aLC.Tag = model.Id;
            aLC.companyNameLabel.Text = model.companyName;
            aLC.jobLocationLabel.Text = model.jobLocation;
            aLC.jobTitleLabel.Text = model.jobTitle;
            aLC.dateAppliedLabel.Text = $"Applied on { model.dateApplied.ToShortDateString() }";

            // Check the status of the application
            if (model.status)
            {
                aLC.statusLabel.Text = "Open";
                aLC.statusLabel.ForeColor = Color.Green;
                aLC.BackColor = Color.White;
            }
            else
            {
                aLC.statusLabel.Text = "Closed";
                aLC.statusLabel.ForeColor = Color.Red;
                aLC.BackColor = Color.LightSalmon;
            }

            // Check if there is an app URL or not
            if (model.appPageURL != "")
            {
                aLC.urlHiddenLabel.Text = model.appPageURL;
            }
            else
            {
                aLC.urlLinkButton.Hide();
            }
            return aLC;
        }

        public void UpdateControl()
        {

        }
    }
}
