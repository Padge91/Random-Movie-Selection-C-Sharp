using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieClass
{
    //the main frame to show
    public partial class MainFrame : Form
    {

        //list to hold movies
        public ArrayList list = new ArrayList();

        public MainFrame()
        {
            InitializeComponent();
        }

        //load event for a frame. loads the films and picks a random one
        private void MainFrame_Load(object sender, EventArgs e)
        {
            loadFilms();
            randomFilm();
        }

        //method for a movie to get sent to this frame
        public void sendMovie(MovieClass movie)
        {
            //add the object to the array list
            if (movie != null)
            {
                list.Add(movie);
            }
            else
            {
                return;
            }

            //save the films
            saveFilms();
        }

        //add button event to make a new addFrame
        private void addButton_Click(object sender, EventArgs e)
        {
            new AddFrame(this).Show();
        }

        //search button event to make a new searchFrame
        private void searchButton_Click(object sender, EventArgs e)
        {
            new SearchFrame(this).Show();
        }

        //exit button event to close the window
        private void exitButton_Click(object sender, EventArgs e)
        {
            saveFilms();
            this.Dispose();
        }

        //random film button event to choose a random film
        private void randomFilmButton_Click(object sender, EventArgs e)
        {
            randomFilm();
        }

        //method to get a random film from the list
        private void randomFilm()
        {
            //make sure list isnt empty
            if (list.Count > 0)
            {
                //get a random object from array list 
                Random gen = new Random();
                //send to display film
                displayFilm(gen.Next(0, list.Count));
            }
        }

        //display film method
        public void displayFilm(int i)
        {
            MovieClass movie = (MovieClass)list[i];
            // set the text and picture values
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = movie.Picture;
            titleLabel.Text = movie.Title;
            ratingLabel.Text = movie.Rating.ToString();
            genreLabel.Text = movie.Genre;
        }

        //remove film method
        public void removeFilm(int i)
        {
            list.RemoveAt(i);
            if (list.Count == 0)
            {
                titleLabel.Text = "";
                genreLabel.Text = "";
                ratingLabel.Text = "";
                pictureBox1.Image = null;
            }
        }

        //load film method
        private void loadFilms()
        {
            
            //variables for alphabetizing
            bool done = false;
            int position = 1;
            MovieClass temp, film1, film2;
            

            //open the file and add each film to the array list
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("data", FileMode.Open, FileAccess.Read, FileShare.Read);

            list = (ArrayList)formatter.Deserialize(fs);
            fs.Close();

                //alphabetize the list
                 while (!done) 
                 {
                     if (position == (list.Count - 1))
                     {
                         done = true;
                         continue;
                     }

                     film1 = (MovieClass)list[position - 1];
                     film2 = (MovieClass)list[position];
                     if (String.Compare(film1.Title, film2.Title, false) <= 0)
                     {
                            //do nothing
                     }
                     else if (String.Compare(film1.Title, film2.Title, false) > 0)
                     {
                         temp = (MovieClass)film1;
                         list[position - 1] = film2;
                         list[position] = temp;
                         
                         if (position <= 1)
                         {
                             position = 1;
                         }
                         else
                         {
                             position = position - 2;
                         }
                     }
                  


                     position++;
                 }
            
        }

        //method to save films
        private void saveFilms()
        {
            //check if the file exists, and if it doesnt, create it
            if (!File.Exists("data"))
            {
                FileStream fs2 = File.Create("data");
                fs2.Close();
            }
            //save objects to file
            FileStream fs = new FileStream("data", FileMode.Truncate, FileAccess.Write, FileShare.Read);
            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, list);
            fs.Close();

        }
    }
}
