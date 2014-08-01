using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;


namespace MovieClass
{
    //class to represent a movie
    [Serializable]
    public class MovieClass
    {
        //members of the class
        private String title;
        private int rating;
        private String genre;
        private Image picture;

        //properties for accessing data members
        public String Title
        {
            get { return title; }
        }

        public int Rating
        {
            get { return rating; }
        }

        public String Genre
        {
            get { return genre; }
        }

        public Image Picture
        {
            get { return picture; }
        }

        //constructor for movie class - checks fields again just in case
        public MovieClass(String t, int r, String g, Image p) {
            if ((t.Length == 0) || (r > 10) || (r < 0) || (g.Length == 0) || (p == null))
            {
                System.Windows.Forms.MessageBox.Show("Error in creating MovieClass object");
                return;
            }

            //set the properties 
            title = t;
            rating = r;
            genre = g;
            picture = p;
        }


    }
}
