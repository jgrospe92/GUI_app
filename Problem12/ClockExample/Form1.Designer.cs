
namespace ClockExample
{
    partial class Form1
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
            this.clockUserControl1 = new ClockExample.ClockUserControl();
            this.SuspendLayout();
            // 
            // clockUserControl1
            // 
            this.clockUserControl1.Location = new System.Drawing.Point(45, 34);
            this.clockUserControl1.Name = "clockUserControl1";
            this.clockUserControl1.Size = new System.Drawing.Size(155, 109);
            this.clockUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 123);
            this.Controls.Add(this.clockUserControl1);
            this.Name = "Form1";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private ClockUserControl clockUserControl1;
    }
}

