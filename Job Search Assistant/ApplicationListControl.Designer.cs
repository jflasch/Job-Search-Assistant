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
            this.upperTextLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.urlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.urlHiddenLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateAppliedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upperTextLabel
            // 
            this.upperTextLabel.AutoSize = true;
            this.upperTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperTextLabel.Location = new System.Drawing.Point(3, -2);
            this.upperTextLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.upperTextLabel.Name = "upperTextLabel";
            this.upperTextLabel.Size = new System.Drawing.Size(254, 21);
            this.upperTextLabel.TabIndex = 2;
            this.upperTextLabel.Text = "<company name> | <job location>";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(3, 20);
            this.jobTitleLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(84, 21);
            this.jobTitleLabel.TabIndex = 3;
            this.jobTitleLabel.Text = "<job title>";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(3, 89);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(70, 21);
            this.notesLabel.TabIndex = 7;
            this.notesLabel.Text = "<notes>";
            // 
            // urlLinkLabel
            // 
            this.urlLinkLabel.AutoSize = true;
            this.urlLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLinkLabel.Location = new System.Drawing.Point(3, 66);
            this.urlLinkLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.urlLinkLabel.Name = "urlLinkLabel";
            this.urlLinkLabel.Size = new System.Drawing.Size(167, 21);
            this.urlLinkLabel.TabIndex = 8;
            this.urlLinkLabel.TabStop = true;
            this.urlLinkLabel.Text = "Go to Application Page";
            this.urlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLinkLabel_LinkClicked);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteButton.Location = new System.Drawing.Point(392, 3);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(85, 28);
            this.addNoteButton.TabIndex = 9;
            this.addNoteButton.Text = "Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
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
            this.statusLabel.Location = new System.Drawing.Point(404, 34);
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
            this.dateAppliedLabel.Location = new System.Drawing.Point(3, 43);
            this.dateAppliedLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dateAppliedLabel.Name = "dateAppliedLabel";
            this.dateAppliedLabel.Size = new System.Drawing.Size(117, 21);
            this.dateAppliedLabel.TabIndex = 12;
            this.dateAppliedLabel.Text = "<date applied>";
            // 
            // ApplicationListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dateAppliedLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.urlHiddenLabel);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.urlLinkLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.upperTextLabel);
            this.Name = "ApplicationListControl";
            this.Size = new System.Drawing.Size(480, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label upperTextLabel;
        public System.Windows.Forms.Label jobTitleLabel;
        public System.Windows.Forms.Label notesLabel;
        public System.Windows.Forms.LinkLabel urlLinkLabel;
        public System.Windows.Forms.Button addNoteButton;
        public System.Windows.Forms.Label urlHiddenLabel;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label dateAppliedLabel;
    }
}
