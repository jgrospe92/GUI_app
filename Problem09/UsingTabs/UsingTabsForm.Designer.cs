
namespace UsingTabs
{
    partial class UsingTabsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
            this.helloRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(17, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 210);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.greenRadioButton);
            this.tabPage1.Controls.Add(this.redRadioButton);
            this.tabPage1.Controls.Add(this.blackRadioButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(243, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(8, 59);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(56, 19);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(8, 33);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 19);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(8, 7);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(53, 19);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.size20RadioButton);
            this.tabPage2.Controls.Add(this.size16RadioButton);
            this.tabPage2.Controls.Add(this.size12RadioButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(243, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Size";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Location = new System.Drawing.Point(7, 58);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(68, 19);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.TabStop = true;
            this.size20RadioButton.Text = "20 point";
            this.size20RadioButton.UseVisualStyleBackColor = true;
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Location = new System.Drawing.Point(7, 33);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(68, 19);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.TabStop = true;
            this.size16RadioButton.Text = "16 point";
            this.size16RadioButton.UseVisualStyleBackColor = true;
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Location = new System.Drawing.Point(7, 7);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(68, 19);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 point";
            this.size12RadioButton.UseVisualStyleBackColor = true;
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.goodbyeRadioButton);
            this.tabPage3.Controls.Add(this.helloRadioButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(243, 182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Message";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // goodbyeRadioButton
            // 
            this.goodbyeRadioButton.AutoSize = true;
            this.goodbyeRadioButton.Location = new System.Drawing.Point(7, 32);
            this.goodbyeRadioButton.Name = "goodbyeRadioButton";
            this.goodbyeRadioButton.Size = new System.Drawing.Size(76, 19);
            this.goodbyeRadioButton.TabIndex = 1;
            this.goodbyeRadioButton.Text = "Goodbye!";
            this.goodbyeRadioButton.UseVisualStyleBackColor = true;
            this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
            // 
            // helloRadioButton
            // 
            this.helloRadioButton.AutoSize = true;
            this.helloRadioButton.Checked = true;
            this.helloRadioButton.Location = new System.Drawing.Point(7, 7);
            this.helloRadioButton.Name = "helloRadioButton";
            this.helloRadioButton.Size = new System.Drawing.Size(56, 19);
            this.helloRadioButton.TabIndex = 0;
            this.helloRadioButton.TabStop = true;
            this.helloRadioButton.Text = "Hello!";
            this.helloRadioButton.UseVisualStyleBackColor = true;
            this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(243, 182);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabs are used to organize controls and conserve space.";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoEllipsis = true;
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.Location = new System.Drawing.Point(1, 234);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(284, 32);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Hello!";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsingTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "UsingTabsForm";
            this.Text = "Using Tabs";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.RadioButton size20RadioButton;
        private System.Windows.Forms.RadioButton size16RadioButton;
        private System.Windows.Forms.RadioButton size12RadioButton;
        private System.Windows.Forms.RadioButton goodbyeRadioButton;
        private System.Windows.Forms.RadioButton helloRadioButton;
        private System.Windows.Forms.Label label1;
    }
}

