namespace Job_Search_Assistant
{
    partial class ApplicationListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationListControl));
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.urlHiddenLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateAppliedLabel = new System.Windows.Forms.Label();
            this.jobLocationLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.urlLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(3, 6);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(352, 21);
            this.companyNameLabel.TabIndex = 2;
            this.companyNameLabel.Text = "Fort Dearborn Company Fort Dearborn Company";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(573, 6);
            this.jobTitleLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(338, 21);
            this.jobTitleLabel.TabIndex = 3;
            this.jobTitleLabel.Text = "Entry Level Software Engineer in Test New Grad";
            // 
            // urlHiddenLabel
            // 
            this.urlHiddenLabel.AutoSize = true;
            this.urlHiddenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlHiddenLabel.Location = new System.Drawing.Point(161, 20);
            this.urlHiddenLabel.Name = "urlHiddenLabel";
            this.urlHiddenLabel.Size = new System.Drawing.Size(0, 21);
            this.urlHiddenLabel.TabIndex = 10;
            this.urlHiddenLabel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(1153, 6);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(77, 21);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "<status>";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // dateAppliedLabel
            // 
            this.dateAppliedLabel.AutoSize = true;
            this.dateAppliedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAppliedLabel.Location = new System.Drawing.Point(917, 6);
            this.dateAppliedLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateAppliedLabel.Name = "dateAppliedLabel";
            this.dateAppliedLabel.Size = new System.Drawing.Size(230, 21);
            this.dateAppliedLabel.TabIndex = 12;
            this.dateAppliedLabel.Text = "Applied on September 12, 2018";
            // 
            // jobLocationLabel
            // 
            this.jobLocationLabel.AutoSize = true;
            this.jobLocationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLocationLabel.Location = new System.Drawing.Point(361, 6);
            this.jobLocationLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.jobLocationLabel.Name = "jobLocationLabel";
            this.jobLocationLabel.Size = new System.Drawing.Size(206, 21);
            this.jobLocationLabel.TabIndex = 13;
            this.jobLocationLabel.Text = "Elk Grove Village, IL Chicago";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Location = new System.Drawing.Point(1385, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(28, 27);
            this.editButton.TabIndex = 14;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(1419, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(28, 27);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // urlLinkButton
            // 
            this.urlLinkButton.BackColor = System.Drawing.Color.White;
            this.urlLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.urlLinkButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.urlLinkButton.FlatAppearance.BorderSize = 0;
            this.urlLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlLinkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLinkButton.ForeColor = System.Drawing.Color.White;
            this.urlLinkButton.Image = ((System.Drawing.Image)(resources.GetObject("urlLinkButton.Image")));
            this.urlLinkButton.Location = new System.Drawing.Point(1351, 3);
            this.urlLinkButton.Name = "urlLinkButton";
            this.urlLinkButton.Size = new System.Drawing.Size(28, 27);
            this.urlLinkButton.TabIndex = 16;
            this.urlLinkButton.UseVisualStyleBackColor = false;
            this.urlLinkButton.Click += new System.EventHandler(this.urlLinkButton_Click);
            // 
            // ApplicationListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.urlLinkButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.jobLocationLabel);
            this.Controls.Add(this.dateAppliedLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.urlHiddenLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "ApplicationListControl";
            this.Size = new System.Drawing.Size(1452, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label companyNameLabel;
        public System.Windows.Forms.Label jobTitleLabel;
        public System.Windows.Forms.Label urlHiddenLabel;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label dateAppliedLabel;
        public System.Windows.Forms.Label jobLocationLabel;
        public System.Windows.Forms.Button editButton;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button urlLinkButton;
    }
}
