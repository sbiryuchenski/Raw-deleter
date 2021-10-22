
namespace Raw_deleter
{
    partial class ListsForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.rawListBox = new System.Windows.Forms.ListBox();
            this.jpegListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(298, 283);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(120, 283);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // rawListBox
            // 
            this.rawListBox.FormattingEnabled = true;
            this.rawListBox.Location = new System.Drawing.Point(31, 18);
            this.rawListBox.Name = "rawListBox";
            this.rawListBox.Size = new System.Drawing.Size(199, 212);
            this.rawListBox.TabIndex = 2;
            this.rawListBox.SelectedIndexChanged += new System.EventHandler(this.rawListBox_SelectedIndexChanged);
            // 
            // jpegListBox
            // 
            this.jpegListBox.FormattingEnabled = true;
            this.jpegListBox.Location = new System.Drawing.Point(261, 18);
            this.jpegListBox.Name = "jpegListBox";
            this.jpegListBox.Size = new System.Drawing.Size(199, 212);
            this.jpegListBox.TabIndex = 3;
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 354);
            this.ControlBox = false;
            this.Controls.Add(this.jpegListBox);
            this.Controls.Add(this.rawListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListsForm";
            this.Text = "Lists of files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox rawListBox;
        private System.Windows.Forms.ListBox jpegListBox;
    }
}