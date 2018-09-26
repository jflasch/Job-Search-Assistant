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
        private string sortType = "Apply Date (Default)";
        private List<ApplicationModel> modelsToView = new List<ApplicationModel>();
        private bool hideChecked = false;

        public ApplicationsListForm()
        {
            InitializeComponent();
            LoadListData();
            //LoadTestData();
            PopulateFlowLayout(applicationModels);
            CalculateStatistics();
        }

        private void LoadTestData()
        {
            applicationModels.Add(new ApplicationModel {
                companyName = "Foxconn",
                jobLocation = "Racine, WI",
                jobTitle = "Software Engineer",
                status = true, Id = 1,
                appPageURL = "https:///stackoverflow.com/questions/4833111/insert-value-into-a-string-at-a-certain-position"
            });
        }

        /// <summary>
        /// Load all job applications from the database
        /// </summary>
        private void LoadListData()
        {
            applicationModels = GlobalConfig.Connection.GetApplicationModels_All();
        }

        /// <summary>
        /// Create an ApplicationListControl for each job application and add them to the flow layout
        /// </summary>
        private void PopulateFlowLayout(List<ApplicationModel> modelsToView)
        {
            applicationsListFlowLayout.Controls.Clear();           
            sortBy(sortType);
            
            foreach (ApplicationModel model in modelsToView)
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
                } else
                {
                    aLC.urlLinkButton.Hide();
                }

                applicationsListFlowLayout.Controls.Add(aLC);
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            LoadListData();
            PopulateFlowLayout(applicationModels);
            CalculateStatistics();
        }

        /// <summary>
        /// Sort the list of job applications by the given type
        /// </summary>
        /// <param name="sortType">Type by which the applications should be sorted</param>
        private void sortBy(string sortType)
        {
            if (sortType == "Apply Date (Default)")
            {
                // Sort the list of applications by dateApplied in descending order (most recent appears first)
                applicationModels.Sort((x, y) => y.dateApplied.CompareTo(x.dateApplied));
            } else if (sortType == "Location")
            {
                // Sort the list of applications by location (city name)
                applicationModels.Sort((x, y) => x.jobLocation.CompareTo(y.jobLocation));
            }
            else if (sortType == "Status")
            {
                // Sort the list of applications by status (open first, closed at the bottom)
                applicationModels.Sort((x, y) => y.dateApplied.CompareTo(x.dateApplied));
                applicationModels.Sort((x, y) => y.status.CompareTo(x.status));
            }
        }

        private void sortingDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortType = sortingDropDown.Text;
            LoadListData();
            PopulateFlowLayout(applicationModels);
        }

        private void searchText_KeyUp(object sender, KeyEventArgs e)
        {
            modelsToView.Clear();
            string search = searchText.Text.ToLower();

            foreach (ApplicationModel model in applicationModels)
            {
                string modelText = model.companyName.ToLower() + " " + model.jobLocation.ToLower() + " " + model.jobTitle.ToLower();
                if (modelText.Contains(search) && !hideChecked)
                {
                    modelsToView.Add(model);
                } else if (modelText.Contains(search) && hideChecked && model.status)
                {
                    modelsToView.Add(model);
                }
            }
            PopulateFlowLayout(modelsToView);
        }

        private void hideClosedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
