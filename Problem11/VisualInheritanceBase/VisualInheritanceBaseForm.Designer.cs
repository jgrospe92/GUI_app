
namespace VisualInheritanceBase
{
    partial class VisualInheritanceBaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.learnMoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugs, Bugs, Bugs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright 2017, Deitel & Associates, Inc.";
            // 
            // learnMoreButton
            // 
            this.learnMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.learnMoreButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learnMoreButton.Location = new System.Drawing.Point(12, 78);
            this.learnMoreButton.Name = "learnMoreButton";
            this.learnMoreButton.Size = new System.Drawing.Size(124, 44);
            this.learnMoreButton.TabIndex = 2;
            this.learnMoreButton.Text = "Learn More";
            this.learnMoreButton.UseVisualStyleBackColor = true;
            this.learnMoreButton.Click += new System.EventHandler(this.learnMoreButton_Click);
            // 
            // VisualInheritanceBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 189);
            this.Controls.Add(this.learnMoreButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VisualInheritanceBaseForm";
            this.Text = "Visual Inheritance Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button learnMoreButton;
    }
}

