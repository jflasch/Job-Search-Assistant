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
            applicationModels.Sort((x, y) => y.dateApplied.CompareTo(x.dateApplied));
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
            applicationsListFlowLayout.Controls.Clear();
            PopulateFlowLayout();
        }
    }
}
