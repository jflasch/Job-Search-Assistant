namespace Job_Search_Assistant
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.applyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateAppliedLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleText = new System.Windows.Forms.TextBox();
            this.jobLocationLabel = new System.Windows.Forms.Label();
            this.jobLocationText = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameText = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesText = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applyDateDateTimePicker
            // 
            this.applyDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.applyDateDateTimePicker.Location = new System.Drawing.Point(193, 193);
            this.applyDateDateTimePicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.applyDateDateTimePicker.Name = "applyDateDateTimePicker";
            this.applyDateDateTimePicker.Size = new System.Drawing.Size(255, 29);
            this.applyDateDateTimePicker.TabIndex = 17;
            this.applyDateDateTimePicker.Value = new System.DateTime(2018, 9, 11, 15, 11, 58, 0);
            // 
            // dateAppliedLabel
            // 
            this.dateAppliedLabel.AutoSize = true;
            this.dateAppliedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAppliedLabel.Location = new System.Drawing.Point(57, 196);
            this.dateAppliedLabel.Name = "dateAppliedLabel";
            this.dateAppliedLabel.Size = new System.Drawing.Size(89, 21);
            this.dateAppliedLabel.TabIndex = 22;
            this.dateAppliedLabel.Text = "Apply Date:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(57, 229);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(74, 21);
            this.urlLabel.TabIndex = 21;
            this.urlLabel.Text = "App URL:";
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(193, 226);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(255, 29);
            this.urlText.TabIndex = 19;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(57, 130);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(70, 21);
            this.jobTitleLabel.TabIndex = 20;
            this.jobTitleLabel.Text = "Job Title:";
            // 
            // jobTitleText
            // 
            this.jobTitleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleText.Location = new System.Drawing.Point(193, 127);
            this.jobTitleText.Name = "jobTitleText";
            this.jobTitleText.Size = new System.Drawing.Size(255, 29);
            this.jobTitleText.TabIndex = 14;
            // 
            // jobLocationLabel
            // 
            this.jobLocationLabel.AutoSize = true;
            this.jobLocationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLocationLabel.Location = new System.Drawing.Point(57, 163);
            this.jobLocationLabel.Name = "jobLocationLabel";
            this.jobLocationLabel.Size = new System.Drawing.Size(100, 21);
            this.jobLocationLabel.TabIndex = 18;
            this.jobLocationLabel.Text = "Job Location:";
            // 
            // jobLocationText
            // 
            this.jobLocationText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLocationText.Location = new System.Drawing.Point(193, 160);
            this.jobLocationText.Name = "jobLocationText";
            this.jobLocationText.Size = new System.Drawing.Size(255, 29);
            this.jobLocationText.TabIndex = 16;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(57, 97);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(126, 21);
            this.companyNameLabel.TabIndex = 15;
            this.companyNameLabel.Text = "Company Name:";
            // 
            // companyNameText
            // 
            this.companyNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameText.Location = new System.Drawing.Point(193, 94);
            this.companyNameText.Name = "companyNameText";
            this.companyNameText.Size = new System.Drawing.Size(255, 29);
            this.companyNameText.TabIndex = 13;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(129, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(255, 37);
            this.headerLabel.TabIndex = 23;
            this.headerLabel.Text = "Edit Job Application";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(57, 265);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(54, 21);
            this.notesLabel.TabIndex = 24;
            this.notesLabel.Text = "Notes:";
            // 
            // notesText
            // 
            this.notesText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesText.Location = new System.Drawing.Point(117, 265);
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(331, 116);
            this.notesText.TabIndex = 25;
            this.notesText.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(373, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 29);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(153, 420);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(197, 17);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.Text = "Please fill in all required fields";
            this.errorLabel.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 446);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.notesText);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.applyDateDateTimePicker);
            this.Controls.Add(this.dateAppliedLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobTitleText);
            this.Controls.Add(this.jobLocationLabel);
            this.Controls.Add(this.jobLocationText);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyNameText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker applyDateDateTimePicker;
        private System.Windows.Forms.Label dateAppliedLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox jobTitleText;
        private System.Windows.Forms.Label jobLocationLabel;
        private System.Windows.Forms.TextBox jobLocationText;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameText;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.RichTextBox notesText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label errorLabel;
    }
}