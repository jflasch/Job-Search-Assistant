namespace Job_Search_Assistant
{
    partial class AddForm
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
            this.companyNameText = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.jobLocationLabel = new System.Windows.Forms.Label();
            this.jobLocationText = new System.Windows.Forms.TextBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // companyNameText
            // 
            this.companyNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameText.Location = new System.Drawing.Point(221, 86);
            this.companyNameText.Name = "companyNameText";
            this.companyNameText.Size = new System.Drawing.Size(174, 26);
            this.companyNameText.TabIndex = 0;
            this.companyNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.companyNameLabel.Location = new System.Drawing.Point(89, 89);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(132, 20);
            this.companyNameLabel.TabIndex = 1;
            this.companyNameLabel.Text = "*Company Name:";
            // 
            // jobLocationLabel
            // 
            this.jobLocationLabel.AutoSize = true;
            this.jobLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jobLocationLabel.Location = new System.Drawing.Point(89, 153);
            this.jobLocationLabel.Name = "jobLocationLabel";
            this.jobLocationLabel.Size = new System.Drawing.Size(110, 20);
            this.jobLocationLabel.TabIndex = 3;
            this.jobLocationLabel.Text = "*Job Location:";
            // 
            // jobLocationText
            // 
            this.jobLocationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLocationText.Location = new System.Drawing.Point(221, 150);
            this.jobLocationText.Name = "jobLocationText";
            this.jobLocationText.Size = new System.Drawing.Size(174, 26);
            this.jobLocationText.TabIndex = 2;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jobTitleLabel.Location = new System.Drawing.Point(89, 121);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(78, 20);
            this.jobTitleLabel.TabIndex = 5;
            this.jobTitleLabel.Text = "*Job Title:";
            this.jobTitleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // jobTitleText
            // 
            this.jobTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleText.Location = new System.Drawing.Point(221, 118);
            this.jobTitleText.Name = "jobTitleText";
            this.jobTitleText.Size = new System.Drawing.Size(174, 26);
            this.jobTitleText.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.Location = new System.Drawing.Point(320, 218);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 29);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(87, 37);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(315, 31);
            this.headerLabel.TabIndex = 7;
            this.headerLabel.Text = "Add New Job Application";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urlLabel.Location = new System.Drawing.Point(100, 185);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(79, 20);
            this.urlLabel.TabIndex = 10;
            this.urlLabel.Text = "App URL:";
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(221, 182);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(174, 26);
            this.urlText.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(136, 262);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(222, 16);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Please fill in the required fields";
            this.errorLabel.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 306);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobTitleText);
            this.Controls.Add(this.jobLocationLabel);
            this.Controls.Add(this.jobLocationText);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyNameText);
            this.Name = "AddForm";
            this.Text = "Job Search Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyNameText;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label jobLocationLabel;
        private System.Windows.Forms.TextBox jobLocationText;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox jobTitleText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label errorLabel;
    }
}

