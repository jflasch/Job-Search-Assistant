using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Search_Assistant
{
    public partial class ApplicationListControl : UserControl
    {
        public ApplicationListControl()
        {
            InitializeComponent();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {

        }

        private void urlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start(urlHiddenLabel.Text);
        }

        private void middleTextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
