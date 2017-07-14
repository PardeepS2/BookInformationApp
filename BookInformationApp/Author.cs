using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp
{
    class Author
    {
        private string name;
        private Book[] books;
        private string email;
        private Date DOB;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public Author(string name, string email, char gender, Book[] books)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.books = books;
        }


    }
}
