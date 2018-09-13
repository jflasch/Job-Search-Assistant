﻿using System;
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
            //LoadTestData();
            PopulateFlowLayout();
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
                    aLC.BackColor = Color.White;
                }
                else
                {
                    aLC.statusLabel.Text = "Closed";
                    aLC.statusLabel.ForeColor = Color.Red;
                    aLC.BackColor = Color.LightSalmon;
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
            PopulateFlowLayout();
        }
    }
}
