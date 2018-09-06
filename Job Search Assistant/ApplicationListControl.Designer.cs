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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobLocationLabel = new System.Windows.Forms.Label();
            this.dateAppliedLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.urlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.companyNameLabel.Location = new System.Drawing.Point(3, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(179, 20);
            this.companyNameLabel.TabIndex = 2;
            this.companyNameLabel.Text = "<company name           >";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jobTitleLabel.Location = new System.Drawing.Point(3, 20);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(233, 20);
            this.jobTitleLabel.TabIndex = 3;
            this.jobTitleLabel.Text = "<job title                                       >";
            // 
            // jobLocationLabel
            // 
            this.jobLocationLabel.AutoSize = true;
            this.jobLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jobLocationLabel.Location = new System.Drawing.Point(188, 0);
            this.jobLocationLabel.Name = "jobLocationLabel";
            this.jobLocationLabel.Size = new System.Drawing.Size(107, 20);
            this.jobLocationLabel.TabIndex = 4;
            this.jobLocationLabel.Text = "<job location>";
            // 
            // dateAppliedLabel
            // 
            this.dateAppliedLabel.AutoSize = true;
            this.dateAppliedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateAppliedLabel.Location = new System.Drawing.Point(301, 0);
            this.dateAppliedLabel.Name = "dateAppliedLabel";
            this.dateAppliedLabel.Size = new System.Drawing.Size(114, 20);
            this.dateAppliedLabel.TabIndex = 6;
            this.dateAppliedLabel.Text = "<date applied>";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.notesLabel.Location = new System.Drawing.Point(3, 60);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(67, 20);
            this.notesLabel.TabIndex = 7;
            this.notesLabel.Text = "<notes>";
            // 
            // urlLinkLabel
            // 
            this.urlLinkLabel.AutoSize = true;
            this.urlLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLinkLabel.Location = new System.Drawing.Point(10, 40);
            this.urlLinkLabel.Name = "urlLinkLabel";
            this.urlLinkLabel.Size = new System.Drawing.Size(172, 20);
            this.urlLinkLabel.TabIndex = 8;
            this.urlLinkLabel.TabStop = true;
            this.urlLinkLabel.Text = "Go to Application Page";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(242, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(71, 20);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "<status>";
            // 
            // addNoteButton
            // 
            this.addNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNoteButton.Location = new System.Drawing.Point(319, 36);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(85, 28);
            this.addNoteButton.TabIndex = 9;
            this.addNoteButton.Text = "Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            // 
            // ApplicationListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.urlLinkLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.dateAppliedLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.jobLocationLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Name = "ApplicationListControl";
            this.Size = new System.Drawing.Size(486, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.Label jobLocationLabel;
        private System.Windows.Forms.Label dateAppliedLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.LinkLabel urlLinkLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addNoteButton;
    }
}
