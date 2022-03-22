﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTest
{
    public partial class MenuTestForm : Form
    {
        public MenuTestForm()
        {
            InitializeComponent();
        }

        // display MessageBox when aboout ToolStripMenuitem is selected.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example\nof using menus.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // exit program when Exit ToolStripMenuItem is selected
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // reset checkmarks for Color ToolStripMenuItems
        private void ClearColor()
        {
            // clear all checkmarks
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }


        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for color
            ClearColor();

            // set color to black
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void ClearFont()
        {
            timesToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicToolStripMenuItem.Checked = false;
        }
        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset checkmarks for Font Tools
            ClearFont();

            // Set font
            timesToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14, displayLabel.Font.Style);
        }

        private void comicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans MS", 14, displayLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkmark
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;

            // use Xor to toggle bold, keep all other styles
            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
