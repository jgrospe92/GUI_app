
namespace ListViewTest
{
    partial class ListViewTestForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.browserListView = new System.Windows.Forms.ListView();
            this.displayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // browserListView
            // 
            this.browserListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.browserListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.browserListView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.browserListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.browserListView.Location = new System.Drawing.Point(12, 31);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(445, 186);
            this.browserListView.SmallImageList = this.fileFolderImageList;
            this.browserListView.TabIndex = 0;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.View = System.Windows.Forms.View.SmallIcon;
            this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(75, 12);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 15);
            this.displayLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // fileFolderImageList
            // 
            this.fileFolderImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.fileFolderImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ListViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.browserListView);
            this.Name = "ListViewTestForm";
            this.Text = "ListViewTest";
            this.Load += new System.EventHandler(this.ListViewTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList fileFolderImageList;
    }
}

