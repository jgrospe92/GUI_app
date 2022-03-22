﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMDI
{
    public partial class ChildForm : Form
    {
        public ChildForm(string title, string resourceName)
        {
            InitializeComponent();

            Text = title;
            displayPitcureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject(resourceName));
        }
    }
}
