namespace MovieClass
{
    partial class MainFrame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.randomFilmButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 13);
            this.titleLabel.TabIndex = 1;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(164, 30);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(0, 13);
            this.ratingLabel.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(164, 59);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(0, 13);
            this.genreLabel.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(174, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Film";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // randomFilmButton
            // 
            this.randomFilmButton.Location = new System.Drawing.Point(255, 226);
            this.randomFilmButton.Name = "randomFilmButton";
            this.randomFilmButton.Size = new System.Drawing.Size(88, 23);
            this.randomFilmButton.TabIndex = 7;
            this.randomFilmButton.Text = "Random Film";
            this.randomFilmButton.UseVisualStyleBackColor = true;
            this.randomFilmButton.Click += new System.EventHandler(this.randomFilmButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(93, 226);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 256);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.randomFilmButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button randomFilmButton;
        private System.Windows.Forms.Button searchButton;
    }
}