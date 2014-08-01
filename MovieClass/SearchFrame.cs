using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;


namespace MovieClass
{
    //frame for search frame
    public partial class SearchFrame : Form
    {
        private MainFrame main;

        //constructor for the search frame
        public SearchFrame(MainFrame main)
        {
            this.main = main;
            InitializeComponent();
        }

        //load event for the search frame
        private void SearchFrame_Load(object sender, EventArgs e)
        {
            MovieClass movie;
            //populate list
            for (int i = 0; i < main.list.Count; i++)
            {
                movie = (MovieClass)main.list[i];
                movieListBox.Items.Add(movie.Title + "\t" + movie.Rating + "\t" + movie.Genre);
            }
        }

        //event for cancel button - closes the window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //select button event
        private void selectButton_Click(object sender, EventArgs e)
        {
            //get film from selection
            if (movieListBox.SelectedIndex != -1)
            {
                main.displayFilm(movieListBox.SelectedIndex);
                this.Dispose();
            }
        }

        //remove button event
        private void removeButton_Click(object sender, EventArgs e)
        {
            //get film from selection
            if (movieListBox.SelectedIndex != -1)
            {
                main.removeFilm(movieListBox.SelectedIndex);
                movieListBox.Items.Remove(movieListBox.SelectedItem);
            }        
        }
    }
}
