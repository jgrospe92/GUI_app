using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeViewDirectoryStructure
{
    public partial class TreeViewDirectoryStructureForm : Form
    {
        string substringDirectory; // store last part of full path name

        public TreeViewDirectoryStructureForm()
        {
            InitializeComponent();
        }

        // populate current node with subdirectories
        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            // array stores all subdirectories in the directory
            string[] directoryArray = Directory.GetDirectories(directoryValue);

            // populate current node with subdirectories
            try
            {
                // check to see if any subdirectory are present
                if(directoryValue.Length != 0)
                {
                    // for every subdirectory, create new Treenode,
                    // add as a child of current node and recursively
                    // populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        // obtain last part of path name from the full path
                        // name by calling the GetFileNameWithoutExtension
                        // method of class path
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);

                        // create Treenode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        // add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        // recursively populate every subdirectory
                        PopulateTreeView(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
           
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // clear all nodes
            directoryTreeView.Nodes.Clear();

            // check if the directory entered by user exist
            // if it does, then fill in the Treeview
            // if not, display error mesagebox
            if (Directory.Exists(inputTextBox.Text))
            {
                // add full path name to directoryTreeView
                directoryTreeView.Nodes.Add(inputTextBox.Text);

                // insert subfolders
                PopulateTreeView(inputTextBox.Text, directoryTreeView.Nodes[0]);
            }
            // display error messagebox if directory not found
            else
            {
                MessageBox.Show(inputTextBox.Text + " could not be found.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
