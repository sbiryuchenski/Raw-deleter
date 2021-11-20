
namespace Raw_deleter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderChecker = new System.Windows.Forms.FolderBrowserDialog();
            this.rawPathButton = new System.Windows.Forms.Button();
            this.jpegPathButton = new System.Windows.Forms.Button();
            this.RawFolderPathBox = new System.Windows.Forms.TextBox();
            this.JpegFolderPathBox = new System.Windows.Forms.TextBox();
            this.getListButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FolderChecker
            // 
            this.FolderChecker.HelpRequest += new System.EventHandler(this.FolderChecker_HelpRequest);
            // 
            // rawPathButton
            // 
            this.rawPathButton.Location = new System.Drawing.Point(35, 21);
            this.rawPathButton.Name = "rawPathButton";
            this.rawPathButton.Size = new System.Drawing.Size(120, 28);
            this.rawPathButton.TabIndex = 0;
            this.rawPathButton.Text = "Select raw folder";
            this.rawPathButton.UseVisualStyleBackColor = true;
            this.rawPathButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // jpegPathButton
            // 
            this.jpegPathButton.Location = new System.Drawing.Point(35, 143);
            this.jpegPathButton.Name = "jpegPathButton";
            this.jpegPathButton.Size = new System.Drawing.Size(120, 28);
            this.jpegPathButton.TabIndex = 1;
            this.jpegPathButton.Text = "Select JPEG folder";
            this.jpegPathButton.UseVisualStyleBackColor = true;
            this.jpegPathButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RawFolderPathBox
            // 
            this.RawFolderPathBox.Location = new System.Drawing.Point(100, 55);
            this.RawFolderPathBox.Name = "RawFolderPathBox";
            this.RawFolderPathBox.Size = new System.Drawing.Size(285, 20);
            this.RawFolderPathBox.TabIndex = 2;
            this.RawFolderPathBox.TextChanged += new System.EventHandler(this.RawFolderPathBox_TextChanged);
            // 
            // JpegFolderPathBox
            // 
            this.JpegFolderPathBox.Location = new System.Drawing.Point(100, 177);
            this.JpegFolderPathBox.Name = "JpegFolderPathBox";
            this.JpegFolderPathBox.Size = new System.Drawing.Size(285, 20);
            this.JpegFolderPathBox.TabIndex = 3;
            this.JpegFolderPathBox.TextChanged += new System.EventHandler(this.JpegFolderPathBox_TextChanged);
            // 
            // getListButton
            // 
            this.getListButton.Location = new System.Drawing.Point(35, 248);
            this.getListButton.Name = "getListButton";
            this.getListButton.Size = new System.Drawing.Size(127, 23);
            this.getListButton.TabIndex = 4;
            this.getListButton.Text = "Get List files to delete";
            this.getListButton.UseVisualStyleBackColor = true;
            this.getListButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(291, 248);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 322);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.getListButton);
            this.Controls.Add(this.JpegFolderPathBox);
            this.Controls.Add(this.RawFolderPathBox);
            this.Controls.Add(this.jpegPathButton);
            this.Controls.Add(this.rawPathButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Raw deleter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.FolderBrowserDialog FolderChecker;
        private System.Windows.Forms.Button rawPathButton;
        private System.Windows.Forms.Button jpegPathButton;
        private System.Windows.Forms.TextBox RawFolderPathBox;
        private System.Windows.Forms.TextBox JpegFolderPathBox;
        private System.Windows.Forms.Button getListButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

