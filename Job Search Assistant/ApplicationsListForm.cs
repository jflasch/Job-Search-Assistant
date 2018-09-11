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
            //CreateSampleData();
            LoadListData();
            PopulateFlowLayout();
        }

        private void LoadListData()
        {
            applicationModels = GlobalConfig.Connection.GetApplicationModels_All();
        }

        private void CreateSampleData()
        {
            applicationModels.Add(new ApplicationModel { companyName = "Company 1", jobLocation = "Chicago, IL", jobTitle = "Engineer", Id = 1 });
            applicationModels.Add(new ApplicationModel { companyName = "Company 2", jobLocation = "Madison, WI", jobTitle = "Developer", Id = 2 });

        }

        private void PopulateFlowLayout()
        {
            foreach (ApplicationModel model in applicationModels)
            {
                ApplicationListControl aLC = new ApplicationListControl();
                aLC.Tag = model.Id;
                aLC.upperTextLabel.Text = $"{ model.companyName } | { model.jobLocation }";
                aLC.middleTextLabel.Text = $"{ model.jobTitle } | Applied on { model.dateApplied.ToShortDateString() }";
                if (model.status)
                {
                    aLC.label1.Text = "Open";
                    aLC.label1.ForeColor = Color.Green;
                }
                else
                {
                    aLC.label1.Text = "Closed";
                    aLC.label1.ForeColor = Color.Red;
                }
                if (model.notes == "" || model.notes == null)
                {
                    aLC.notesLabel.Visible = false;
                }
                aLC.urlHiddenLabel.Text = model.appPageURL;
                applicationsListFlowLayout.Controls.Add(aLC);
            }
        }

        private void ClearFlowLayout()
        {
            //List<Control> listControls = applicationsListFlowLayout.Controls.ToList();

            foreach (Control control in applicationsListFlowLayout.Controls)
            {
                applicationsListFlowLayout.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            //ClearFlowLayout();
            LoadListData();
            applicationsListFlowLayout.Controls.Clear();
            PopulateFlowLayout();
        }
    }
}
