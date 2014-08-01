using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieClass
{

    //class for frame to add new films to the list

    public partial class AddFrame : Form
    {
        private MainFrame main;

        //constructor that passes the main frame to this object
        public AddFrame(MainFrame main)
        {
            this.main = main;
            InitializeComponent();
        }

        //event for clicking the add button
        private void addButton_Click(object sender, EventArgs e)
        {
            //ensure all fields are not empty
            if ((titleTextBox.Text.Length == 0) || (ratingtextBox.Text.Length == 0) || (genreComboBox.SelectedIndex == -1) || (pictureBox.Image == null))
            {
                System.Windows.Forms.MessageBox.Show("All fields must be selected, including the picture");
                return;
            }

            //make sure rating is an integer
            int i;
            bool isNumber = int.TryParse(ratingtextBox.Text, out i);
            if (!isNumber)
            {
                System.Windows.Forms.MessageBox.Show("Rating must be an integer");
                return;
            }

            //make sure the rating is between 0 and 10
            if ((i > 10) || (i < 0))
            {
                System.Windows.Forms.MessageBox.Show("Rating must be an integer between 0 and 10");
                return;
            }

            //send a new movie object to the main frame, and then close the adding frame
            main.sendMovie(new MovieClass(titleTextBox.Text, i, (String)genreComboBox.SelectedItem, pictureBox.Image));
            this.Dispose();
        }

        //set up the event to have the cancel button close the frame
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //event for button click to select an image
        private void button1_Click(object sender, EventArgs e)
        {
            //set up images allowed to be selected
            openFileDialog1.Filter = "JPG files |*.jpg|JPEG Files |*.jpeg|GIF Files |*.gif|PNG FILES |*.png|BMP FILES |*.bmp";
           
            //open the dialog to select a file and get the image file
            DialogResult closed = openFileDialog1.ShowDialog();
            if ((closed == DialogResult.OK) && (openFileDialog1.FileName.Length > 0))
            {
                //set the image for a preview
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else if (closed == DialogResult.Cancel)
            {
                openFileDialog1.Dispose();
                return;
            }


        }
    }
}
