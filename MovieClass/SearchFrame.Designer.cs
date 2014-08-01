namespace MovieClass
{
    partial class SearchFrame
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
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.HorizontalScrollbar = true;
            this.movieListBox.Location = new System.Drawing.Point(12, 12);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.ScrollAlwaysVisible = true;
            this.movieListBox.Size = new System.Drawing.Size(362, 199);
            this.movieListBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(218, 218);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(299, 218);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SearchFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 246);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.movieListBox);
            this.Name = "SearchFrame";
            this.Text = "SearchFrame";
            this.Load += new System.EventHandler(this.SearchFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button selectButton;

    }
}