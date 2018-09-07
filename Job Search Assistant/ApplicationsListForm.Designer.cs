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
            this.applicationsListFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addNewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applicationsListFlowLayout
            // 
            this.applicationsListFlowLayout.Location = new System.Drawing.Point(12, 84);
            this.applicationsListFlowLayout.Name = "applicationsListFlowLayout";
            this.applicationsListFlowLayout.Size = new System.Drawing.Size(1460, 765);
            this.applicationsListFlowLayout.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(585, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(262, 31);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "Job Applications List";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addNewButton
            // 
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addNewButton.Location = new System.Drawing.Point(1302, 12);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(142, 66);
            this.addNewButton.TabIndex = 9;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // ApplicationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.applicationsListFlowLayout);
            this.Name = "ApplicationsListForm";
            this.Text = "ApplicationsListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel applicationsListFlowLayout;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addNewButton;
    }
}