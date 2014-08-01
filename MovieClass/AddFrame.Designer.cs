namespace MovieClass
{
    partial class AddFrame
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.ratingtextBox = new System.Windows.Forms.TextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.selectPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(274, 219);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(7, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(4, 35);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 3;
            this.ratingLabel.Text = "Rating:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(6, 61);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(157, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(192, 175);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(51, 6);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 7;
            // 
            // ratingtextBox
            // 
            this.ratingtextBox.Location = new System.Drawing.Point(51, 32);
            this.ratingtextBox.Name = "ratingtextBox";
            this.ratingtextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingtextBox.TabIndex = 8;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "Comedy",
            "Drama",
            "Family",
            "Horror",
            "Suspense"});
            this.genreComboBox.Location = new System.Drawing.Point(51, 58);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(100, 21);
            this.genreComboBox.TabIndex = 9;
            // 
            // selectPicture
            // 
            this.selectPicture.Location = new System.Drawing.Point(157, 190);
            this.selectPicture.Name = "selectPicture";
            this.selectPicture.Size = new System.Drawing.Size(192, 23);
            this.selectPicture.TabIndex = 10;
            this.selectPicture.Text = "Select Picture";
            this.selectPicture.UseVisualStyleBackColor = true;
            this.selectPicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 252);
            this.Controls.Add(this.selectPicture);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.ratingtextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddFrame";
            this.Text = "AddFrame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox ratingtextBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button selectPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}