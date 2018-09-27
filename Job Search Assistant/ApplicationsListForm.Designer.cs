namespace Job_Search_Assistant
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.hideClosedCheckBox = new System.Windows.Forms.CheckBox();
            this.totalApplicationsLabel = new System.Windows.Forms.Label();
            this.openApplicationsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationsListFlowLayout
            // 
            this.applicationsListFlowLayout.AutoScroll = true;
            this.applicationsListFlowLayout.BackColor = System.Drawing.Color.White;
            this.applicationsListFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationsListFlowLayout.Location = new System.Drawing.Point(12, 135);
            this.applicationsListFlowLayout.Name = "applicationsListFlowLayout";
            this.applicationsListFlowLayout.Size = new System.Drawing.Size(1510, 786);
            this.applicationsListFlowLayout.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(618, 9);
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
            // searchText
            // 
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(3, 3);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(170, 22);
            this.searchText.TabIndex = 13;
            this.searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyUp);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Location = new System.Drawing.Point(1161, 49);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(204, 29);
            this.searchPanel.TabIndex = 0;
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.InitialImage = null;
            this.searchIcon.Location = new System.Drawing.Point(177, 5);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(27, 24);
            this.searchIcon.TabIndex = 14;
            this.searchIcon.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(1092, 53);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 21);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search:";
            // 
            // hideClosedCheckBox
            // 
            this.hideClosedCheckBox.AutoSize = true;
            this.hideClosedCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideClosedCheckBox.Location = new System.Drawing.Point(974, 52);
            this.hideClosedCheckBox.Name = "hideClosedCheckBox";
            this.hideClosedCheckBox.Size = new System.Drawing.Size(112, 25);
            this.hideClosedCheckBox.TabIndex = 13;
            this.hideClosedCheckBox.Text = "Hide Closed";
            this.hideClosedCheckBox.UseVisualStyleBackColor = true;
            this.hideClosedCheckBox.CheckedChanged += new System.EventHandler(this.hideClosedCheckBox_CheckedChanged);
            // 
            // totalApplicationsLabel
            // 
            this.totalApplicationsLabel.AutoSize = true;
            this.totalApplicationsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalApplicationsLabel.Location = new System.Drawing.Point(12, 15);
            this.totalApplicationsLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.totalApplicationsLabel.Name = "totalApplicationsLabel";
            this.totalApplicationsLabel.Size = new System.Drawing.Size(138, 21);
            this.totalApplicationsLabel.TabIndex = 14;
            this.totalApplicationsLabel.Text = "Total Applications: ";
            // 
            // openApplicationsLabel
            // 
            this.openApplicationsLabel.AutoSize = true;
            this.openApplicationsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openApplicationsLabel.Location = new System.Drawing.Point(12, 38);
            this.openApplicationsLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.openApplicationsLabel.Name = "openApplicationsLabel";
            this.openApplicationsLabel.Size = new System.Drawing.Size(144, 21);
            this.openApplicationsLabel.TabIndex = 15;
            this.openApplicationsLabel.Text = "Open Applications: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Job Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(934, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date Applied";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1170, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            // 
            // ApplicationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 933);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openApplicationsLabel);
            this.Controls.Add(this.totalApplicationsLabel);
            this.Controls.Add(this.hideClosedCheckBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.applicationsListFlowLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationsListForm";
            this.Text = "Job Search Assistant";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel applicationsListFlowLayout;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.CheckBox hideClosedCheckBox;
        private System.Windows.Forms.Label totalApplicationsLabel;
        private System.Windows.Forms.Label openApplicationsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}