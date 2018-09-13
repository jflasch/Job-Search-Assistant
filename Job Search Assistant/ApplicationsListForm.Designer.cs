﻿namespace Job_Search_Assistant
{
    partial class ApplicationsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationsListForm));
            this.applicationsListFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addNewButton = new System.Windows.Forms.Button();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.sortingDropDown = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // applicationsListFlowLayout
            // 
            this.applicationsListFlowLayout.AutoScroll = true;
            this.applicationsListFlowLayout.Location = new System.Drawing.Point(12, 84);
            this.applicationsListFlowLayout.Name = "applicationsListFlowLayout";
            this.applicationsListFlowLayout.Size = new System.Drawing.Size(1510, 837);
            this.applicationsListFlowLayout.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(609, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(260, 37);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "Job Applications List";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addNewButton
            // 
            this.addNewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(1380, 12);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(142, 66);
            this.addNewButton.TabIndex = 9;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByLabel.Location = new System.Drawing.Point(1122, 15);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(63, 21);
            this.sortByLabel.TabIndex = 10;
            this.sortByLabel.Text = "Sort By:";
            // 
            // sortingDropDown
            // 
            this.sortingDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortingDropDown.FormattingEnabled = true;
            this.sortingDropDown.Items.AddRange(new object[] {
            "Apply Date (Default)",
            "Status",
            "Location"});
            this.sortingDropDown.Location = new System.Drawing.Point(1191, 12);
            this.sortingDropDown.Name = "sortingDropDown";
            this.sortingDropDown.Size = new System.Drawing.Size(174, 29);
            this.sortingDropDown.TabIndex = 11;
            this.sortingDropDown.Text = "Apply Date (Default)";
            this.sortingDropDown.SelectedIndexChanged += new System.EventHandler(this.sortingDropDown_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(1122, 52);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 21);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search:";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(1191, 49);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(174, 29);
            this.searchText.TabIndex = 13;
            this.searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyUp);
            // 
            // ApplicationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 933);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.sortingDropDown);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.applicationsListFlowLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationsListForm";
            this.Text = "Job Search Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel applicationsListFlowLayout;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.ComboBox sortingDropDown;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
    }
}