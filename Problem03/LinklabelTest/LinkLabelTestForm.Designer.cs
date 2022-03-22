
namespace LinklabelTest
{
    partial class LinkLabelTestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cdDriveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deitelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notePadLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cdDriveLinkLabel
            // 
            this.cdDriveLinkLabel.AutoSize = true;
            this.cdDriveLinkLabel.Location = new System.Drawing.Point(20, 21);
            this.cdDriveLinkLabel.Name = "cdDriveLinkLabel";
            this.cdDriveLinkLabel.Size = new System.Drawing.Size(107, 15);
            this.cdDriveLinkLabel.TabIndex = 0;
            this.cdDriveLinkLabel.TabStop = true;
            this.cdDriveLinkLabel.Text = "Click to browse C:\\";
            this.cdDriveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cdDriveLinkLabel_LinkClicked);
            // 
            // deitelLinkLabel
            // 
            this.deitelLinkLabel.AutoSize = true;
            this.deitelLinkLabel.Location = new System.Drawing.Point(20, 52);
            this.deitelLinkLabel.Name = "deitelLinkLabel";
            this.deitelLinkLabel.Size = new System.Drawing.Size(160, 15);
            this.deitelLinkLabel.TabIndex = 1;
            this.deitelLinkLabel.TabStop = true;
            this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
            this.deitelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deitelLinkLabel_LinkClicked);
            // 
            // notePadLinkedLabel
            // 
            this.notePadLinkedLabel.AutoSize = true;
            this.notePadLinkedLabel.Location = new System.Drawing.Point(20, 83);
            this.notePadLinkedLabel.Name = "notePadLinkedLabel";
            this.notePadLinkedLabel.Size = new System.Drawing.Size(117, 15);
            this.notePadLinkedLabel.TabIndex = 2;
            this.notePadLinkedLabel.TabStop = true;
            this.notePadLinkedLabel.Text = "Click to run Notepad";
            this.notePadLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notePadLinkedLabel_LinkClicked);
            // 
            // LinkLabelTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 120);
            this.Controls.Add(this.notePadLinkedLabel);
            this.Controls.Add(this.deitelLinkLabel);
            this.Controls.Add(this.cdDriveLinkLabel);
            this.Name = "LinkLabelTestForm";
            this.Text = "LinkLabelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel cdDriveLinkLabel;
        private System.Windows.Forms.LinkLabel deitelLinkLabel;
        private System.Windows.Forms.LinkLabel notePadLinkedLabel;
    }
}

