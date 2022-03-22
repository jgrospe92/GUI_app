
namespace VisualInheritanceTest
{
    partial class VisualInheritanceTestForm
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
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutButton.Location = new System.Drawing.Point(142, 78);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(136, 44);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About this program";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // VisualInheritanceTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 202);
            this.Controls.Add(this.aboutButton);
            this.Name = "VisualInheritanceTestForm";
            this.Text = "Visual Inheritance Test";
            this.Controls.SetChildIndex(this.aboutButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutButton;
    }
}

