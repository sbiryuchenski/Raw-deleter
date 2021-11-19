
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
            this.DeleteListBox = new System.Windows.Forms.ListBox();
            this.textRaws = new System.Windows.Forms.Label();
            this.textWillDelete = new System.Windows.Forms.Label();
            this.textJpegs = new System.Windows.Forms.Label();
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
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.rawListBox.Size = new System.Drawing.Size(114, 212);
            this.rawListBox.TabIndex = 2;
            this.rawListBox.SelectedIndexChanged += new System.EventHandler(this.rawListBox_SelectedIndexChanged);
            // 
            // jpegListBox
            // 
            this.jpegListBox.FormattingEnabled = true;
            this.jpegListBox.Location = new System.Drawing.Point(342, 18);
            this.jpegListBox.Name = "jpegListBox";
            this.jpegListBox.Size = new System.Drawing.Size(114, 212);
            this.jpegListBox.TabIndex = 3;
            this.jpegListBox.SelectedIndexChanged += new System.EventHandler(this.jpegListBox_SelectedIndexChanged);
            // 
            // DeleteListBox
            // 
            this.DeleteListBox.FormattingEnabled = true;
            this.DeleteListBox.Location = new System.Drawing.Point(169, 18);
            this.DeleteListBox.Name = "DeleteListBox";
            this.DeleteListBox.Size = new System.Drawing.Size(150, 212);
            this.DeleteListBox.TabIndex = 4;
            // 
            // textRaws
            // 
            this.textRaws.AutoSize = true;
            this.textRaws.Location = new System.Drawing.Point(70, 233);
            this.textRaws.Name = "textRaws";
            this.textRaws.Size = new System.Drawing.Size(34, 13);
            this.textRaws.TabIndex = 5;
            this.textRaws.Text = "Raws";
            // 
            // textWillDelete
            // 
            this.textWillDelete.AutoSize = true;
            this.textWillDelete.Location = new System.Drawing.Point(218, 233);
            this.textWillDelete.Name = "textWillDelete";
            this.textWillDelete.Size = new System.Drawing.Size(52, 13);
            this.textWillDelete.TabIndex = 6;
            this.textWillDelete.Text = "To delete";
            // 
            // textJpegs
            // 
            this.textJpegs.AutoSize = true;
            this.textJpegs.Location = new System.Drawing.Point(380, 233);
            this.textJpegs.Name = "textJpegs";
            this.textJpegs.Size = new System.Drawing.Size(35, 13);
            this.textJpegs.TabIndex = 7;
            this.textJpegs.Text = "Jpegs";
            this.textJpegs.Click += new System.EventHandler(this.label3_Click);
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 354);
            this.ControlBox = false;
            this.Controls.Add(this.textJpegs);
            this.Controls.Add(this.textWillDelete);
            this.Controls.Add(this.textRaws);
            this.Controls.Add(this.DeleteListBox);
            this.Controls.Add(this.jpegListBox);
            this.Controls.Add(this.rawListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListsForm";
            this.Text = "Lists of files";
            this.Load += new System.EventHandler(this.ListsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox rawListBox;
        private System.Windows.Forms.ListBox jpegListBox;
        private System.Windows.Forms.ListBox DeleteListBox;
        private System.Windows.Forms.Label textRaws;
        private System.Windows.Forms.Label textWillDelete;
        private System.Windows.Forms.Label textJpegs;
    }
}