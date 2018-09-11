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

        public ApplicationsListForm()
        {
            InitializeComponent();
            LoadListData();
            PopulateFlowLayout();
        }

        private void LoadListData()
        {
            applicationModels = GlobalConfig.Connection.GetApplicationModels_All();
        }

        private void PopulateFlowLayout()
        {
            applicationsListFlowLayout.Controls.Clear();
            sortBy(sortType);

            foreach (ApplicationModel model in applicationModels)
            {
                ApplicationListControl aLC = new ApplicationListControl();
                aLC.Tag = model.Id;
                aLC.upperTextLabel.Text = $"{ model.companyName } | { model.jobLocation }";
                aLC.jobTitleLabel.Text = model.jobTitle;
                aLC.dateAppliedLabel.Text = $"Applied on { model.dateApplied.ToShortDateString() }";
                if (model.status)
                {
                    aLC.statusLabel.Text = "Open";
                    aLC.statusLabel.ForeColor = Color.Green;
                }
                else
                {
                    aLC.statusLabel.Text = "Closed";
                    aLC.statusLabel.ForeColor = Color.Red;
                }
                if (model.notes == "" || model.notes == null)
                {
                    aLC.notesLabel.Visible = false;
                }
                aLC.urlHiddenLabel.Text = model.appPageURL;
                applicationsListFlowLayout.Controls.Add(aLC);
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            LoadListData();
            PopulateFlowLayout();
        }

        private void sortBy(string sortType)
        {
            if (sortType == "Apply Date (Default)")
            {
                // Sort the list of applications by dateApplied in descending order (most recent appears first)
                applicationModels.Sort((x, y) => y.dateApplied.CompareTo(x.dateApplied));
            } else if (sortType == "Location")
            {
                // TODO - Sort by location
                applicationModels.Sort((x, y) => x.jobLocation.CompareTo(y.jobLocation));
            }
            else if (sortType == "Status")
            {
                // TODO - Sort by Status
                applicationModels.Sort((x, y) => y.dateApplied.CompareTo(x.dateApplied));
                applicationModels.Sort((x, y) => x.status.CompareTo(y.status));
            }
        }

        private void sortingDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortType = sortingDropDown.Text;
            PopulateFlowLayout();
        }
    }
}
