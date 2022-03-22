using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinklabelTest
{
    public partial class LinkLabelTestForm : Form
    {
        public LinkLabelTestForm()
        {
            InitializeComponent();
        }

        // browse C:\
        private void cdDriveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change LinkColor after it has been clicked
            cdDriveLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start(@"C:\");
        }

        private void deitelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deitelLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deitel.com");
        }

        private void notePadLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notePadLinkedLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
