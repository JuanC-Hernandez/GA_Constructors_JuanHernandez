using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_JuanHernandez
{
    internal class Books
    {
        private string title;
        private string author;

        
        public Books() // Default constructor: will have title and author filled
        {
            title = "n/a";
            author = "n/a";
        }// user has no information
        public Books(string title) //constructor 3: will require title from user, and no author
        {
            this.title = title;
            author = "n/a";
        }// incase user only has title
        public Books(string title, string author) //constructor 2: will require user to enter title and author
        {
            this.title = title;
            this.author = author;
        }// if user has both author and title
        //contructor overloading provides flexibility b/c it allows user not to have all the information ready but make modifications later on
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }
}
