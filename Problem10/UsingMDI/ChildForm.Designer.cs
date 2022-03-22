
namespace UsingMDI
{
    partial class ChildForm
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
            this.displayPitcureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayPitcureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPitcureBox
            // 
            this.displayPitcureBox.Location = new System.Drawing.Point(21, 22);
            this.displayPitcureBox.Name = "displayPitcureBox";
            this.displayPitcureBox.Size = new System.Drawing.Size(236, 213);
            this.displayPitcureBox.TabIndex = 0;
            this.displayPitcureBox.TabStop = false;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 257);
            this.Controls.Add(this.displayPitcureBox);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            ((System.ComponentModel.ISupportInitialize)(this.displayPitcureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox displayPitcureBox;
    }
}